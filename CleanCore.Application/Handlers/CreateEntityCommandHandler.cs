using CleanCore.Application.Commands;
using CleanCore.Application.Services;
using CleanCore.Domain.Common;
using CleanCore.Domain.Events;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CleanCore.Application.Handlers;

/// <summary>
/// The create entity command handler class
/// </summary>
/// <seealso cref="IRequestHandler{CreateEntityCommand, ErrorOr}"/>
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

/// <summary>
/// The create elastic entity command handler class
/// </summary>
/// <seealso cref="BaseElasticCommandHandler{TId, TEntity, TDto}"/>
/// <seealso cref="IRequestHandler{CreateEntityCommand, ErrorOr}"/>
public class CreateElasticEntityCommandHandler<TId, TEntity, TDto> : BaseElasticCommandHandler<TId, TEntity, TDto>, IRequestHandler<CreateEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateElasticEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    public CreateElasticEntityCommandHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
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
            .ThenAsync(async entity =>
            {
                try
                {
                return await IndexAsync(entity);
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entity => entity.ToDto());
    }
}