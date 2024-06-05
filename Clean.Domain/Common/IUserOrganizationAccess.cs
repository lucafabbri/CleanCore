namespace Clean.Domain.Common;

/// <summary>
/// The user organization access interface
/// </summary>
public interface IUserOrganizationAccess
{
    /// <summary>
    /// Gets the value of the access
    /// </summary>
    UserOrganizationAccess Access { get; }
    /// <summary>
    /// Gets the value of the user
    /// </summary>
    IUser User { get; }
}
