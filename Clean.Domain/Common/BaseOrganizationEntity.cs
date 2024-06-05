namespace Clean.Domain.Common;

/// <summary>
/// The base organization entity class
/// </summary>
/// <seealso cref="BaseEntity{TId, TEntity, TDto}"/>
/// <seealso cref="IOrganizationEntity{TOrganizationId}"/>
public abstract class BaseOrganizationEntity<TId, TOrganizationId, TEntity, TDto> : BaseEntity<TId, TEntity, TDto>, IOrganizationEntity<TOrganizationId>
    where TId : IEquatable<TId>
    where TEntity : BaseOrganizationEntity<TId, TOrganizationId, TEntity, TDto>
    where TOrganizationId : IEquatable<TOrganizationId>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseOrganizationEntity{TId,TOrganizationId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="organizationId">The organization id</param>
    protected BaseOrganizationEntity(TId id, TOrganizationId organizationId) : base(id)
    {
        OrganizationId = organizationId;
    }

    /// <summary>
    /// Gets or sets the value of the organization id
    /// </summary>
    public TOrganizationId OrganizationId { get; set; }
}
