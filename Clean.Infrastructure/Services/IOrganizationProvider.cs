using Clean.Domain.Common;
using ErrorOr;

namespace Clean.Infrastructure.Services
{
    /// <summary>
    /// The organization provider interface
    /// </summary>
    public interface IOrganizationProvider<TOrganizationId>
    where TOrganizationId : IEquatable<TOrganizationId>
    {
        /// <summary>
        /// Gets the organization
        /// </summary>
        /// <returns>An error or of i organization t organization id</returns>
        ErrorOr<IOrganization<TOrganizationId>> GetOrganization();
    }
}
