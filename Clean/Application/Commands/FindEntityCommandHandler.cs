using Clean.Application.DTO;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public class FindEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<FindEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityContext<TId, TEntity, TDto> _context;

    public FindEntityCommandHandler(IEntityContext<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public async Task<ErrorOr<TDto>> Handle(FindEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await _context.Find(request.Id)
            .Then(entity => entity.ToDto());
    }
}
