using Clean.Application.Commands;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

public abstract class DeleteManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<DeleteManyEntityCommand<TId, TEntity, TDto>, ErrorOr<Deleted>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly DbContext _context;

    public DeleteManyEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    public virtual async Task<ErrorOr<Deleted>> Handle(DeleteManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await (await _context.Set<TEntity>().Where(entity => request.Ids.Contains(entity.Id)).ToListAsync()).ToErrorOr()
            .Then(entities =>
            {
                foreach (var entity in entities)
                {
                    entity.AddDomainEvent(new EntityDeletedEvent<TId, TEntity, TDto>(entity));
                }
                return entities;
            })
            .ThenAsync<Deleted>(async entities =>
            {
                try
                {
                    _context.Set<TEntity>().RemoveRange(entities);
                    await _context.SaveChangesAsync(cancellationToken);
                    return Result.Deleted;
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            });
    }
}
