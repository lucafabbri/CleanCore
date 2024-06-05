using Clean.Domain.Common;

namespace Clean.Examples.CounterWebApp.Domain
{
    /// <summary>
    /// The app organization class
    /// </summary>
    /// <seealso cref="IOrganization{Int}"/>
    public class AppOrganization : IOrganization<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppOrganization"/> class
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="name">The name</param>
        /// <param name="userAccess">The user access</param>
        public AppOrganization(int id, string name, IEnumerable<IUserOrganizationAccess> userAccess)
        {
            Id = id;
            Name = name;
            UserAccess = userAccess;
        }

        /// <summary>
        /// Gets or sets the value of the id
        /// </summary>
        public int Id {  get; set; }

        /// <summary>
        /// Gets or sets the value of the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the user access
        /// </summary>
        public IEnumerable<IUserOrganizationAccess> UserAccess { get; set; } = [];
    }
}
