using Clean.Application.DTO;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public class UpsertEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<UpsertEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityContext<TId, TEntity, TDto> _context;

    public UpsertEntityCommandHandler(IEntityContext<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public async Task<ErrorOr<TDto>> Handle(UpsertEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dto.ToEntity()
            .ToErrorOr()
            .ThenAsync(async entity => await _context.Upsert(entity, cancellationToken))
            .Then(entity => entity.ToDto());
    }
}
