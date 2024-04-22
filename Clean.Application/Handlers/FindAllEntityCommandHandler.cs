using Clean.Application.Commands;
using Clean.Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

public abstract class FindAllEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<FindAllEntityCommand<TId, TEntity, TDto>, IEnumerable<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly DbContext _context;

    public FindAllEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    public virtual async Task<IEnumerable<TDto>> Handle(FindAllEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return (await _context.Set<TEntity>().ToListAsync()).Select(x => x.ToDto());
    }
}
