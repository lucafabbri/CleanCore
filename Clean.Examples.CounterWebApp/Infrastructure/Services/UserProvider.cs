using Clean.Domain.Common;
using Clean.Examples.CounterWebApp.Domain;
using Clean.Infrastructure.Services;
using ErrorOr;

namespace Clean.Examples.CounterWebApp.Infrastructure.Services
{
    public class UserProvider : IUserProvider
    {
        public static IUser SystemUser = new AppUser(1, "System");
        public ErrorOr<IUser> GetCurrentUser()
        {
            return SystemUser.ToErrorOr();
        }
    }
}
