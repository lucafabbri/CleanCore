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
/// The modify entity command handler class
/// </summary>
/// <seealso cref="IRequestHandler{ModifyEntityCommand, ErrorOr}"/>
public abstract class ModifyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<ModifyEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// The context
    /// </summary>
    private readonly DbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="ModifyEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public ModifyEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an error or of t dto</returns>
    public virtual async Task<ErrorOr<TDto>> Handle(ModifyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dto.ToEntity()
            .ToErrorOr()
            .Then(entity => entity.AddDomainEvent(new EntityModifiedEvent<TId, TEntity, TDto>(entity)))
            .ThenAsync<TEntity>(async entity =>
            {
                try
                {
                    return await _context.Set<TEntity>().Find(entity.Id)
                        .ToErrorOr()
                        .FailIf(_ => _ == null, Error.NotFound())
                        .Then(oldEntity => oldEntity!.Update(entity))
                        .ThenAsync(async entity =>
                        {
                            _context.Set<TEntity>().Update(entity);
                            await _context.SaveChangesAsync(cancellationToken);
                            return entity;
                        });
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entity => entity.ToDto());
    }
}

/// <summary>
/// The modify elastic entity command handler class
/// </summary>
/// <seealso cref="BaseElasticCommandHandler{TId, TEntity, TDto}"/>
/// <seealso cref="IRequestHandler{ModifyEntityCommand, ErrorOr}"/>
public abstract class ModifyElasticEntityCommandHandler<TId, TEntity, TDto> : BaseElasticCommandHandler<TId, TEntity, TDto>, IRequestHandler<ModifyEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ModifyElasticEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    protected ModifyElasticEntityCommandHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an error or of t dto</returns>
    public virtual async Task<ErrorOr<TDto>> Handle(ModifyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken) => await request.Dto.ToEntity()
            .ToErrorOr()
            .Then(entity => entity.AddDomainEvent(new EntityModifiedEvent<TId, TEntity, TDto>(entity)))
            .ThenAsync(UpdateAsync)
            .Then(entity => entity.ToDto());
}
