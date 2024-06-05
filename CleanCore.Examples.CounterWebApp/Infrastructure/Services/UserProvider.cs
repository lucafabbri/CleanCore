using CleanCore.Domain.Common;
using CleanCore.Examples.CounterWebApp.Domain;
using CleanCore.Infrastructure.Services;
using ErrorOr;

namespace CleanCore.Examples.CounterWebApp.Infrastructure.Services
{
    /// <summary>
    /// The user provider class
    /// </summary>
    /// <seealso cref="IUserProvider"/>
    public class UserProvider : IUserProvider
    {
        /// <summary>
        /// The app user
        /// </summary>
        public static IUser SystemUser = new AppUser(1, "System");
        /// <summary>
        /// Gets the current user
        /// </summary>
        /// <returns>An error or of i user</returns>
        public ErrorOr<IUser> GetCurrentUser()
        {
            return SystemUser.ToErrorOr();
        }
    }
}
