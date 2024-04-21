namespace Clean.Domain.Common;

public interface IOrganization<TOrganizationId>
    where TOrganizationId : IEquatable<TOrganizationId>
{
    TOrganizationId Id { get; }
    string Name { get; }

    IEnumerable<IUserOrganizationAccess> UserAccess { get; }
}
