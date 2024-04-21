using Clean.Application.Commands;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;

namespace Clean.Application.Handlers;

public abstract class DeleteEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<DeleteEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityRepository<TId, TEntity, TDto> _repository;

    public DeleteEntityCommandHandler(IEntityRepository<TId, TEntity, TDto> context)
    {
        _repository = context;
    }

    public virtual async Task<ErrorOr<TDto>> Handle(DeleteEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await _repository.Find(request.Id)
            .Then(entity => entity.AddDomainEvent(new EntityDeletedEvent<TId, TEntity, TDto>(entity)))
            .ThenAsync(async entity => await _repository.Delete(entity, cancellationToken))
            .Then(entity => entity.ToDto());
    }
}