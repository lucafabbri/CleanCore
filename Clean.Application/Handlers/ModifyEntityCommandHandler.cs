using Clean.Application.Commands;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;

namespace Clean.Application.Handlers;

public abstract class ModifyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<ModifyEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityRepository<TId, TEntity, TDto> _context;

    public ModifyEntityCommandHandler(IEntityRepository<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public virtual async Task<ErrorOr<TDto>> Handle(ModifyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dto.ToEntity()
            .ToErrorOr()
            .Then(entity => entity.AddDomainEvent(new EntityModifiedEvent<TId, TEntity, TDto>(entity)))
            .ThenAsync(async entity => await _context.Update(entity, cancellationToken))
            .Then(entity => entity.ToDto());
    }
}
