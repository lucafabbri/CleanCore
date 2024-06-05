namespace CleanCore.Domain.Common;

/// <summary>
/// The create entity dto interface
/// </summary>
public interface ICreateEntityDto<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Returns the entity
    /// </summary>
    /// <returns>The entity</returns>
    TEntity ToEntity();
}
