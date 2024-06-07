namespace CleanCore.Domain.Common;

/// <summary>
/// The entity dto class
/// </summary>
/// <seealso cref="IEntityDto{TId, TEntity, TDto}"/>
public abstract class EntityDto<TId, TEntity, TDto>:IEntityDto<TId, TEntity, TDto>, ICreateEntityDto<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Gets the value of the id
    /// </summary>
    public TId? Id { get; set; }
    /// <summary>
    /// Gets the value of the created at
    /// </summary>
    public DateTimeOffset CreatedAt { get; set; }
    /// <summary>
    /// Gets the value of the created by
    /// </summary>
    public string? CreatedBy { get; set; }
    /// <summary>
    /// Gets the value of the last modified at
    /// </summary>
    public DateTimeOffset LastModifiedAt { get; set; }
    /// <summary>
    /// Gets the value of the last modified by
    /// </summary>
    public string? LastModifiedBy { get; set; }
    /// <summary>
    /// Gets the value of the deleted at
    /// </summary>
    public DateTimeOffset? DeletedAt { get; set; }
    /// <summary>
    /// Gets the value of the deleted by
    /// </summary>
    public string? DeletedBy { get; set; }
    /// <summary>
    /// Returns the entity
    /// </summary>
    /// <returns>The entity</returns>
    public abstract TEntity ToEntity();
}
