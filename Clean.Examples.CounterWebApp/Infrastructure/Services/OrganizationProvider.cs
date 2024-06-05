using Clean.Domain.Common;
using Clean.Examples.CounterWebApp.Domain;
using Clean.Infrastructure.Services;
using ErrorOr;

namespace Clean.Examples.CounterWebApp.Infrastructure.Services
{
    /// <summary>
    /// The organization provider class
    /// </summary>
    /// <seealso cref="IOrganizationProvider{Int}"/>
    public class OrganizationProvider : IOrganizationProvider<int>
    {
        /// <summary>
        /// The system user
        /// </summary>
        public static IOrganization<int> SystemOrganization = new AppOrganization(1, "System", [new AppUserOrganizationAccess { Access = UserOrganizationAccess.Owner, User = UserProvider.SystemUser }]);
        /// <summary>
        /// Gets the organization
        /// </summary>
        /// <returns>An error or of i organization int</returns>
        public ErrorOr<IOrganization<int>> GetOrganization()
        {
            return SystemOrganization.ToErrorOr();
        }
    }
}
