using Clean.Domain.Common;
using Clean.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Clean.Infrastructure.Data.Interceptors;

public class OrganizationEntitySaveChangesInterceptor<TOrganizationId> : SaveChangesInterceptor
    where TOrganizationId : IEquatable<TOrganizationId>
{
    private readonly IOrganizationProvider<TOrganizationId> _organizationProvider;

    public OrganizationEntitySaveChangesInterceptor(IOrganizationProvider<TOrganizationId> organizationProvider)
    {
        _organizationProvider = organizationProvider;
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        UpdateEntities(eventData.Context);

        return base.SavingChanges(eventData, result);
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        UpdateEntities(eventData.Context);

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    public async void UpdateEntities(DbContext? context)
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
