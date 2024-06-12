using CleanCore.Domain.Common;
using CleanCore.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using CleanCore.Core.Extensions;

namespace CleanCore.Infrastructure.Data.Interceptors;

/// <summary>
/// The base entity save changes interceptor class
/// </summary>
/// <seealso cref="SaveChangesInterceptor"/>
public class BaseEntitySaveChangesInterceptor : SaveChangesInterceptor
{
    /// <summary>
    /// The date time
    /// </summary>
    private readonly TimeProvider _dateTime;
    /// <summary>
    /// The user provider
    /// </summary>
    private readonly IUserProvider _userProvider;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntitySaveChangesInterceptor"/> class
    /// </summary>
    /// <param name="dateTime">The date time</param>
    /// <param name="userProvider">The user provider</param>
    public BaseEntitySaveChangesInterceptor(TimeProvider dateTime, IUserProvider userProvider)
    {
        _dateTime = dateTime;
        _userProvider = userProvider;
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
