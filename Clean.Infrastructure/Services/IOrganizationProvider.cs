using Clean.Domain.Common;
using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infrastructure.Services
{
    public interface IOrganizationProvider<TOrganizationId>
    where TOrganizationId : IEquatable<TOrganizationId>
    {
        ErrorOr<IOrganization<TOrganizationId>> GetOrganization();
    }
}
