namespace Clean.Domain.Common;

/// <summary>
/// The organization interface
/// </summary>
public interface IOrganization<TOrganizationId>
    where TOrganizationId : IEquatable<TOrganizationId>
{
    /// <summary>
    /// Gets the value of the id
    /// </summary>
    TOrganizationId Id { get; }
    /// <summary>
    /// Gets the value of the name
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the value of the user access
    /// </summary>
    IEnumerable<IUserOrganizationAccess> UserAccess { get; }
}
