using Clean.Application.DTO;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public class DeleteManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<DeleteManyEntityCommand<TId, TEntity, TDto>, ErrorOr<Deleted>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityRepository<TId, TEntity, TDto> _context;

    public DeleteManyEntityCommandHandler(IEntityRepository<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public async Task<ErrorOr<Deleted>> Handle(DeleteManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await (await _context.Where(entity => request.Ids.Contains(entity.Id))).ToErrorOr()
            .Then(entities =>
            {
                foreach(var entity in entities)
                {
                    entity.AddDomainEvent(new EntityDeletedEvent<TId, TEntity, TDto>(entity));
                }
                return entities;
            })
            .ThenAsync(async entities => await _context.DeleteMany(entities, cancellationToken));
    }
}
