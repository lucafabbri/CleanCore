using CleanCore.Domain.Common;

namespace CleanCore.Domain.Events;

/// <summary>
/// The entity modified event class
/// </summary>
/// <seealso cref="BaseEntityEvent{TId, TEntity, TDto}"/>
public class EntityModifiedEvent<TId, TEntity, TDto> : BaseEntityEvent<TId, TEntity, TDto>
where TId : IEquatable<TId>
where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityModifiedEvent{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="entity">The entity</param>
    public EntityModifiedEvent(BaseEntity<TId, TEntity, TDto> entity) : base(entity)
    {
    }
}
