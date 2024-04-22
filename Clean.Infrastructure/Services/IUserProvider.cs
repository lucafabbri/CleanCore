using Clean.Domain.Common;
using ErrorOr;

namespace Clean.Infrastructure.Services
{
    public interface IUserProvider
    {
        ErrorOr<IUser> GetCurrentUser();
    }
}
