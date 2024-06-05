using Clean.Domain.Common;
using ErrorOr;

namespace Clean.Infrastructure.Services
{
    /// <summary>
    /// The user provider interface
    /// </summary>
    public interface IUserProvider
    {
        /// <summary>
        /// Gets the current user
        /// </summary>
        /// <returns>An error or of i user</returns>
        ErrorOr<IUser> GetCurrentUser();
    }
}
