using MediatR;

namespace Clean.Domain.Common;

/// <summary>
/// The base entity event class
/// </summary>
/// <seealso cref="BaseEntityEvent"/>
public class BaseEntityEvent<TId, TEntity, TDto> : BaseEntityEvent
where TId : IEquatable<TId>
where TEntity : BaseEntity<TId, TEntity, TDto>
where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntityEvent{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="entity">The entity</param>
    public BaseEntityEvent(BaseEntity<TId, TEntity, TDto> entity)
    {
        Entity = (entity as TEntity)!;
    }
    /// <summary>
    /// Gets or sets the value of the entity
    /// </summary>
    public TEntity Entity { get; set; }
}

/// <summary>
/// The base entity event class
/// </summary>
/// <seealso cref="INotification"/>
public class BaseEntityEvent : INotification
{

}
