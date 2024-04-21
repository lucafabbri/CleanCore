using Clean.Domain.Common;
using Clean.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Clean.Core.Extensions;

namespace Clean.Infrastructure.Data.Interceptors;

public class BaseEntitySaveChangesInterceptor : SaveChangesInterceptor
{
    private readonly TimeProvider _dateTime;
    private readonly IUserProvider _userProvider;

    public BaseEntitySaveChangesInterceptor(TimeProvider dateTime, IUserProvider userProvider)
    {
        _dateTime = dateTime;
        _userProvider = userProvider;
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

    public void UpdateEntities(DbContext? context)
    {
        if (context == null) return;

        foreach (var entry in context.ChangeTracker.Entries<BaseEntity>())
        {
            if (entry.State is EntityState.Added or EntityState.Modified || entry.HasChangedOwnedEntities())
            {
                var utcNow = _dateTime.GetUtcNow();
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.Created(when: utcNow, by: _userProvider.GetCurrentUser().ValueOrNull()?.Name);
                }
                entry.Entity.Modified(when: utcNow, by: _userProvider.GetCurrentUser().ValueOrNull()?.Name);
            }
        }
    }
}
