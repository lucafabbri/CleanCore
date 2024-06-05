using Clean.Application.Commands;
using Clean.Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

/// <summary>
/// The find all entity command handler class
/// </summary>
/// <seealso cref="IRequestHandler{FindAllEntityCommand{TId, TEntity, TDto}, IEnumerable{TDto}}"/>
public abstract class FindAllEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<FindAllEntityCommand<TId, TEntity, TDto>, IEnumerable<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// The context
    /// </summary>
    private readonly DbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="FindAllEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public FindAllEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an enumerable of t dto</returns>
    public virtual async Task<IEnumerable<TDto>> Handle(FindAllEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return (await _context.Set<TEntity>().ToListAsync()).Select(x => x.ToDto());
    }
}
