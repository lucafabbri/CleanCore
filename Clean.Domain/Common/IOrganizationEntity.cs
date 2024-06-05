namespace Clean.Domain.Common;

/// <summary>
/// The organization entity interface
/// </summary>
public interface IOrganizationEntity<TOrganizationId> where TOrganizationId : IEquatable<TOrganizationId>
{
    /// <summary>
    /// Gets or sets the value of the organization id
    /// </summary>
    public TOrganizationId OrganizationId { get; set; }
}
