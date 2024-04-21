using Clean.Domain.Common;

namespace Clean.Examples.CounterWebApp.Domain
{
    public class AppOrganization : IOrganization<int>
    {
        public AppOrganization(int id, string name, IEnumerable<IUserOrganizationAccess> userAccess)
        {
            Id = id;
            Name = name;
            UserAccess = userAccess;
        }

        public int Id {  get; set; }

        public string Name { get; set; }

        public IEnumerable<IUserOrganizationAccess> UserAccess { get; set; } = [];
    }
}
