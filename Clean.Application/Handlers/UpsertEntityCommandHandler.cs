using Clean.Application.Commands;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;

namespace Clean.Application.Handlers;

public abstract class UpsertEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<UpsertEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityRepository<TId, TEntity, TDto> _context;

    public UpsertEntityCommandHandler(IEntityRepository<TId, TEntity, TDto> context)
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
            .ThenAsync(async entity => await _context.Upsert(entity, cancellationToken))
            .Then(entity => entity.ToDto());
    }
}
