using Clean.Domain.Common;
using Clean.Examples.CounterWebApp.Domain;
using Clean.Infrastructure.Services;
using ErrorOr;

namespace Clean.Examples.CounterWebApp.Infrastructure.Services
{
    public class OrganizationProvider : IOrganizationProvider<int>
    {
        public static IOrganization<int> SystemOrganization = new AppOrganization(1, "System", [new AppUserOrganizationAccess { Access = UserOrganizationAccess.Owner, User = UserProvider.SystemUser }]);
        public ErrorOr<IOrganization<int>> GetOrganization()
        {
            return SystemOrganization.ToErrorOr();
        }
    }
}
