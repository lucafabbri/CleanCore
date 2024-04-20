using Clean.Application.DTO;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using MediatR;

namespace Clean.Application.Commands;

public class FindAllEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<FindAllEntityCommand<TId, TEntity, TDto>, IEnumerable<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityContext<TId, TEntity, TDto> _context;

    public FindAllEntityCommandHandler(IEntityContext<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TDto>> Handle(FindAllEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return (await _context.FindAll()).Select(x => x.ToDto());
    }
}
