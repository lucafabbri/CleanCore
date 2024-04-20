using Clean.Application.DTO;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public class UpsertManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<UpsertManyEntityCommand<TId, TEntity, TDto>, ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityContext<TId, TEntity, TDto> _context;

    public UpsertManyEntityCommandHandler(IEntityContext<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public async Task<ErrorOr<IEnumerable<TDto>>> Handle(UpsertManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dtos.Select(x => x.ToEntity()).ToErrorOr()
            .ThenAsync(async entities => await _context.UpsertMany(entities, cancellationToken))
            .Then(entities => entities.Select(x => x.ToDto()));
    }
}
