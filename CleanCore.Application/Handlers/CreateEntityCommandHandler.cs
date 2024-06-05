using CleanCore.Application.Commands;
using CleanCore.Domain.Common;
using CleanCore.Domain.Events;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanCore.Application.Handlers;

/// <summary>
/// The create entity command handler class
/// </summary>
/// <seealso cref="IRequestHandler{CreateEntityCommand{TId, TEntity, TDto}, ErrorOr{TDto}}"/>
public abstract class CreateEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<CreateEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// The context
    /// </summary>
    private readonly DbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public CreateEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an error or of t dto</returns>
    public virtual async Task<ErrorOr<TDto>> Handle(CreateEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dto.ToEntity()
            .ToErrorOr()
            .Then(entity => entity.AddDomainEvent(new EntityCreationEvent<TId, TEntity, TDto>(entity)))
            .ThenAsync<TEntity>(async entity =>
            {
                try
                {
                    if (!(entity.Id?.Equals(default) ?? false))
                    {
                        return Error.Validation(description: $"Id not null");
                    }
                    await _context.Set<TEntity>().AddAsync(entity);
                    await _context.SaveChangesAsync(cancellationToken);
                    return entity;
                }
                catch(Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entity => entity.ToDto());
    }
}