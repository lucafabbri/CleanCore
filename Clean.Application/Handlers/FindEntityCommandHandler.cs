using Clean.Application.Commands;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

/// <summary>
/// The find entity command handler class
/// </summary>
/// <seealso cref="IRequestHandler{FindEntityCommand{TId, TEntity, TDto}, ErrorOr{TDto}}"/>
public abstract class FindEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<FindEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// The context
    /// </summary>
    private readonly DbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="FindEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public FindEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an error or of t dto</returns>
    public virtual async Task<ErrorOr<TDto>> Handle(FindEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return (await _context.Set<TEntity>().FindAsync(request.Id))
            .ToErrorOr()
            .FailIf(_ => _ == null, Error.NotFound(description: $"{request.Id} not found"))
            .Then(entity => entity!.ToDto());
    }
}
