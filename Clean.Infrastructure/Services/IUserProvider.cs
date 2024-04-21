using Clean.Domain.Common;
using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infrastructure.Services
{
    public interface IUserProvider
    {
        ErrorOr<IUser> GetCurrentUser();
    }
}
