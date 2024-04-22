using Clean.Domain.Common;
using ErrorOr;

namespace Clean.Infrastructure.Services
{
    public interface IOrganizationProvider<TOrganizationId>
    where TOrganizationId : IEquatable<TOrganizationId>
    {
        ErrorOr<IOrganization<TOrganizationId>> GetOrganization();
    }
}
