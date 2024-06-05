namespace Clean.Domain.Common;

/// <summary>
/// The entity dto interface
/// </summary>
public interface IEntityDto<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Gets the value of the id
    /// </summary>
    TId? Id { get; }
    /// <summary>
    /// Gets the value of the created at
    /// </summary>
    DateTimeOffset CreatedAt { get; }
    /// <summary>
    /// Gets the value of the created by
    /// </summary>
    string? CreatedBy { get; }
    /// <summary>
    /// Gets the value of the last modified at
    /// </summary>
    DateTimeOffset LastModifiedAt { get; }
    /// <summary>
    /// Gets the value of the last modified by
    /// </summary>
    string? LastModifiedBy { get; }
    /// <summary>
    /// Gets the value of the deleted at
    /// </summary>
    DateTimeOffset? DeletedAt { get; }
    /// <summary>
    /// Gets the value of the deleted by
    /// </summary>
    string? DeletedBy { get; }
    /// <summary>
    /// Returns the entity
    /// </summary>
    /// <returns>The entity</returns>
    TEntity ToEntity();
}

/// <summary>
/// The entity dto class
/// </summary>
/// <seealso cref="IEntityDto{TId, TEntity, TDto}"/>
public abstract class EntityDto<TId, TEntity, TDto>:IEntityDto<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Gets the value of the id
    /// </summary>
    public TId? Id { get; }
    /// <summary>
    /// Gets the value of the created at
    /// </summary>
    public DateTimeOffset CreatedAt { get; }
    /// <summary>
    /// Gets the value of the created by
    /// </summary>
    public string? CreatedBy { get; }
    /// <summary>
    /// Gets the value of the last modified at
    /// </summary>
    public DateTimeOffset LastModifiedAt { get; }
    /// <summary>
    /// Gets the value of the last modified by
    /// </summary>
    public string? LastModifiedBy { get; }
    /// <summary>
    /// Gets the value of the deleted at
    /// </summary>
    public DateTimeOffset? DeletedAt { get; }
    /// <summary>
    /// Gets the value of the deleted by
    /// </summary>
    public string? DeletedBy { get; }
    /// <summary>
    /// Returns the entity
    /// </summary>
    /// <returns>The entity</returns>
    public abstract TEntity ToEntity();
}
