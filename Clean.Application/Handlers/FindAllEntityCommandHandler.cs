using Clean.Application.Commands;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using MediatR;

namespace Clean.Application.Handlers;

public abstract class FindAllEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<FindAllEntityCommand<TId, TEntity, TDto>, IEnumerable<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityRepository<TId, TEntity, TDto> _context;

    public FindAllEntityCommandHandler(IEntityRepository<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public virtual async Task<IEnumerable<TDto>> Handle(FindAllEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return (await _context.FindAll()).Select(x => x.ToDto());
    }
}
