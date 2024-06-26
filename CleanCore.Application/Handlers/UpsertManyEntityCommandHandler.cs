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
/// The upsert many entity command handler class
/// </summary>
/// <seealso cref="IRequestHandler{UpsertManyEntityCommand, ErrorOr}"/>
public abstract class UpsertManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<UpsertManyEntityCommand<TId, TEntity, TDto>, ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// The context
    /// </summary>
    private readonly DbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="UpsertManyEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public UpsertManyEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an error or of i enumerable t dto</returns>
    public virtual async Task<ErrorOr<IEnumerable<TDto>>> Handle(UpsertManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dtos.Select(x => x.ToEntity()).ToErrorOr()
            .Then(entities =>
            {
                foreach (var entity in entities)
                {
                    entity.AddDomainEvent(
                        entity.Id == null ?
                        new EntityCreationEvent<TId, TEntity, TDto>(entity) :
                        new EntityModifiedEvent<TId, TEntity, TDto>(entity)
                    );
                }
                return entities;
            })
            .ThenAsync(async entities =>
            {
                try
                {
                    foreach (var entity in entities)
                    {
                        if (entity.Id != null && _context.Set<TEntity>().Find(entity.Id) != null)
                        {
                            _context.Set<TEntity>().Update(entity);
                        }
                        else
                        {
                            await _context.Set<TEntity>().AddAsync(entity);
                        }
                    }
                    await _context.SaveChangesAsync(cancellationToken);
                    return entities.ToErrorOr();
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entities => entities.Select(x => x.ToDto()));
    }
}

/// <summary>
/// The upsert many elastic entity command handler class
/// </summary>
/// <seealso cref="BaseElasticCommandHandler{TId, TEntity, TDto}"/>
/// <seealso cref="IRequestHandler{UpsertManyEntityCommand, ErrorOr}"/>
public abstract class UpsertManyElasticEntityCommandHandler<TId, TEntity, TDto> : BaseElasticCommandHandler<TId, TEntity, TDto>, IRequestHandler<UpsertManyEntityCommand<TId, TEntity, TDto>, ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpsertManyElasticEntityCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    protected UpsertManyElasticEntityCommandHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }

    /// <summary>
    /// Handles the request
    /// </summary>
    /// <param name="request">The request</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A task containing an error or of i enumerable t dto</returns>
    public virtual async Task<ErrorOr<IEnumerable<TDto>>> Handle(UpsertManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await request.Dtos.Select(x => x.ToEntity()).ToErrorOr()
            .Then(entities =>
            {
                foreach (var entity in entities)
                {
                    entity.AddDomainEvent(
                        entity.Id == null ?
                        new EntityCreationEvent<TId, TEntity, TDto>(entity) :
                        new EntityModifiedEvent<TId, TEntity, TDto>(entity)
                    );
                }
                return entities;
            })
            .ThenAsync(async entities =>
            {
                try
                {
                    return await IndexManyAsync(entities);
                }
                catch (Exception ex)
                {
                    return Error.Conflict(ex.Message);
                }
            })
            .Then(entities => entities.Select(x => x.ToDto()));
    }
}
