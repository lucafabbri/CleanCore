namespace Clean.Domain.Common
{
    public interface IOrganizationEntity<TOrganizationId> where TOrganizationId : IEquatable<TOrganizationId>
    {
        public TOrganizationId OrganizationId { get; }
    }
}
