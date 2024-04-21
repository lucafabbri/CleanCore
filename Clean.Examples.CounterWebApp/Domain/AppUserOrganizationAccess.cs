using Clean.Domain.Common;

namespace Clean.Examples.CounterWebApp.Domain
{
    public class AppUserOrganizationAccess : IUserOrganizationAccess
    {
        public UserOrganizationAccess Access { get; set; }

        public IUser User { get; set; }
    }
}
