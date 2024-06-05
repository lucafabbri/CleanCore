using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CleanCore.Infrastructure.Data.Interceptors;

/// <summary>
/// The entity entry extensions class
/// </summary>
public static class EntityEntryExtensions
{
    /// <summary>
    /// Hases the changed owned entities using the specified entry
    /// </summary>
    /// <param name="entry">The entry</param>
    /// <returns>The bool</returns>
    public static bool HasChangedOwnedEntities(this EntityEntry entry) =>
        entry.References.Any(r =>
            r.TargetEntry != null &&
            r.TargetEntry.Metadata.IsOwned() &&
            (r.TargetEntry.State == EntityState.Added || r.TargetEntry.State == EntityState.Modified));
}