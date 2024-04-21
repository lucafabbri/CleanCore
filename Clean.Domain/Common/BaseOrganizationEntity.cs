namespace Clean.Domain.Common;

public abstract class BaseOrganizationEntity<TId, TOrganizationId, TEntity, TDto> : BaseEntity<TId, TEntity, TDto>, IOrganizationEntity<TOrganizationId>
    where TId : IEquatable<TId>
    where TEntity : BaseOrganizationEntity<TId, TOrganizationId, TEntity, TDto>
    where TOrganizationId : IEquatable<TOrganizationId>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    protected BaseOrganizationEntity(TId id, TOrganizationId organizationId) : base(id)
    {
        OrganizationId = organizationId;
    }

    public TOrganizationId OrganizationId { get; set; }
}
