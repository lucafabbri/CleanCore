using CleanCore.Domain.Common;
using CleanCore.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CleanCore.Infrastructure.Data.Interceptors;

/// <summary>
/// The organization entity save changes interceptor class
/// </summary>
/// <seealso cref="SaveChangesInterceptor"/>
public class OrganizationEntitySaveChangesInterceptor<TOrganizationId> : SaveChangesInterceptor
    where TOrganizationId : IEquatable<TOrganizationId>
{
    /// <summary>
    /// The organization provider
    /// </summary>
    private readonly IOrganizationProvider<TOrganizationId> _organizationProvider;

    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationEntitySaveChangesInterceptor{TOrganizationId}"/> class
    /// </summary>
    /// <param name="organizationProvider">The organization provider</param>
    public OrganizationEntitySaveChangesInterceptor(IOrganizationProvider<TOrganizationId> organizationProvider)
    {
        _organizationProvider = organizationProvider;
    }

    /// <summary>
    /// Savings the changes using the specified event data
    /// </summary>
    /// <param name="eventData">The event data</param>
    /// <param name="result">The result</param>
    /// <returns>An interception result of int</returns>
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateEntities(eventData.Context);

        return base.SavingChanges(eventData, result);
    }

    /// <summary>
    /// Savings the changes using the specified event data
    /// </summary>
    /// <param name="eventData">The event data</param>
    /// <param name="result">The result</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>A value task of interception result int</returns>
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        UpdateEntities(eventData.Context);

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    /// <summary>
    /// Updates the entities using the specified context
    /// </summary>
    /// <param name="context">The context</param>
    public void UpdateEntities(DbContext? context)
    {
        if (context == null) return;

        foreach (var entry in context.ChangeTracker.Entries<IOrganizationEntity<TOrganizationId>>())
        {
            if (entry.State is EntityState.Added || entry.HasChangedOwnedEntities())
            {
                _organizationProvider.GetOrganization().ThenDo(organization => entry.Entity.OrganizationId = organization.Id);
            }
        }
    }
}
