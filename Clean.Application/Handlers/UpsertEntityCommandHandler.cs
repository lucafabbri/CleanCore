using Clean.Application.Commands;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

public abstract class UpsertEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<UpsertEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly DbContext _context;

    public UpsertEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    public virtual async Task<ErrorOr<TDto>> Handle(UpsertEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dto.ToEntity()
            .ToErrorOr()
            .Then(entity => entity.AddDomainEvent(
                entity.Id == null ?
                new EntityCreationEvent<TId, TEntity, TDto>(entity) :
                new EntityModifiedEvent<TId, TEntity, TDto>(entity)
            ))
            .ThenAsync<TEntity>(async entity =>
            {
                try
                {
                    return await _context.Set<TEntity>().Find(entity.Id)
                    .ToErrorOr()
                    .FailIf(_ => _ == null, Error.NotFound())
                    .Match(
                        oldEntity => oldEntity!.Update(entity)
                            .Then(e =>
                            {
                                _context.Set<TEntity>().Update(e);
                                return entity;
                            }),
                        _ => { 
                            _context.Set<TEntity>().Add(entity); 
                            return entity; 
                        })
                    .ThenAsync(async entity =>
                    {
                        await _context.SaveChangesAsync(cancellationToken);
                        return entity.ToErrorOr();
                    });
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entity => entity.ToDto());
    }
}
