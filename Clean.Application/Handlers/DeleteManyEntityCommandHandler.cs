using Clean.Application.Commands;
using Clean.Domain.Common;
using Clean.Domain.Events;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

/// <summary>
/// The delete many entity command handler class
/// </summary>
/// <seealso cref="IRequestHandler{DeleteManyEntityCommand{TId, TEntity, TDto}, ErrorOr{Deleted}}"/>
public abstract class DeleteManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<DeleteManyEntityCommand<TId, TEntity, TDto>, ErrorOr<Deleted>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// The context
    /// </summary>
    private readonly DbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteManyEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public DeleteManyEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an error or of deleted</returns>
    public virtual async Task<ErrorOr<Deleted>> Handle(DeleteManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await (await _context.Set<TEntity>().Where(entity => request.Ids.Contains(entity.Id)).ToListAsync()).ToErrorOr()
            .Then(entities =>
            {
                foreach (var entity in entities)
                {
                    entity.AddDomainEvent(new EntityDeletedEvent<TId, TEntity, TDto>(entity));
                }
                return entities;
            })
            .ThenAsync<Deleted>(async entities =>
            {
                try
                {
                    _context.Set<TEntity>().RemoveRange(entities);
                    await _context.SaveChangesAsync(cancellationToken);
                    return Result.Deleted;
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            });
    }
}
