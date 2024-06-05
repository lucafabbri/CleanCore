using CleanCore.Domain.Common;

namespace CleanCore.Examples.CounterWebApp.Domain
{
    /// <summary>
    /// The app user organization access class
    /// </summary>
    /// <seealso cref="IUserOrganizationAccess"/>
    public class AppUserOrganizationAccess : IUserOrganizationAccess
    {
        /// <summary>
        /// Gets or sets the value of the access
        /// </summary>
        public UserOrganizationAccess Access { get; set; }

        /// <summary>
        /// Gets or sets the value of the user
        /// </summary>
        public IUser User { get; set; }
    }
}
