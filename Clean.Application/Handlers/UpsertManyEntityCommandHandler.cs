using Clean.Application.Commands;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

public abstract class UpsertManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<UpsertManyEntityCommand<TId, TEntity, TDto>, ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly DbContext _context;

    public UpsertManyEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    public virtual async Task<ErrorOr<IEnumerable<TDto>>> Handle(UpsertManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dtos.Select(x => x.ToEntity()).ToErrorOr()
            .Then(entities =>
            {
                foreach (var entity in entities)
                {
                    entity.AddDomainEvent(
                        entity.Id == null ?
                        new EntityCreationEvent<TId, TEntity, TDto>(entity) :
                        new EntityModifiedEvent<TId, TEntity, TDto>(entity)
                    );
                }
                return entities;
            })
            .ThenAsync<IEnumerable<TEntity>>(async entities =>
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        if (entity.Id != null)
                        {
                            _context.Set<TEntity>().Update(entity);
                        }
                        else
                        {
                            await _context.Set<TEntity>().AddAsync(entity);
                        }
                    }
                    await _context.SaveChangesAsync(cancellationToken);
                    return entities.ToErrorOr();
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entities => entities.Select(x => x.ToDto()));
    }
}
