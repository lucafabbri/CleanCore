using Clean.Domain.Common;

namespace Clean.Domain.Events;

/// <summary>
/// The entity deleted event class
/// </summary>
/// <seealso cref="BaseEntityEvent{TId, TEntity, TDto}"/>
public class EntityDeletedEvent<TId, TEntity, TDto> : BaseEntityEvent<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityDeletedEvent{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="entity">The entity</param>
    public EntityDeletedEvent(BaseEntity<TId, TEntity, TDto> entity) : base(entity)
    {
    }
}
