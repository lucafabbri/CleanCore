namespace Clean.Domain.Common;

public interface IUserOrganizationAccess
{
    UserOrganizationAccess Access { get; }
    IUser User { get; }
}
