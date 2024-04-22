using Clean.Application.Commands;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

public abstract class DeleteEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<DeleteEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly DbContext _context;

    public DeleteEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    public virtual async Task<ErrorOr<TDto>> Handle(DeleteEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>().Find(request.Id)
            .ToErrorOr()
            .FailIf(entity => entity == null, Error.NotFound(description: $"{request.Id} not found"))
            .Then(entity => entity!.AddDomainEvent(new EntityDeletedEvent<TId, TEntity, TDto>(entity)))
            .ThenAsync<TEntity>(async entity =>
            {
                try
                {
                    _context.Set<TEntity>().Remove(entity);
                    await _context.Set<TEntity>().AddAsync(entity);
                    await _context.SaveChangesAsync(cancellationToken);
                    return entity;
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entity => entity.ToDto());
    }
}