using Clean.Application.Commands;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;

namespace Clean.Application.Handlers;

public abstract class UpsertManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<UpsertManyEntityCommand<TId, TEntity, TDto>, ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityRepository<TId, TEntity, TDto> _context;

    public UpsertManyEntityCommandHandler(IEntityRepository<TId, TEntity, TDto> context)
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
            .ThenAsync(async entities => await _context.UpsertMany(entities, cancellationToken))
            .Then(entities => entities.Select(x => x.ToDto()));
    }
}
