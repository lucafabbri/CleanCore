using Clean.Application.Persistence;
using Clean.Domain.Common;
using ErrorOr;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;

namespace Clean.Infrastructure.Persistence;

public class BaseEntityRepository<TId, TEntity, TDto, TDbContext> : IEntityRepository<TId, TEntity, TDto>
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TDbContext: DbContext
{
    private readonly TDbContext _context;

    public BaseEntityRepository(TDbContext context)
    {
        _context = context;
    }

    public IQueryable<TEntity> AsQueryable()
    {
        return _context.Set<TEntity>().AsQueryable();
    }

    public async Task<ErrorOr<TEntity>> Delete(TEntity entity, CancellationToken cancellationToken)
    {
        _context.Set<TEntity>().Remove(entity);
        return await SaveChangesAsync(entity, cancellationToken);
    }

    public async Task<ErrorOr<Deleted>> DeleteMany(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
    {
        _context.Set<TEntity>().RemoveRange(entities);
        return await SaveChangesAsync(Result.Deleted, cancellationToken);
    }

    public async Task<ErrorOr<TEntity>> Find(TId? id)
    {
        if (id == null)
        {
            return Error.NotFound(description: $"{id} not found");
        }
        return (await _context.Set<TEntity>().FindAsync(id))?.ToErrorOr() ?? Error.NotFound(description: $"{id} not found");
    }

    public async Task<IEnumerable<TEntity>> FindAll()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task<ErrorOr<TEntity>> Insert(TEntity entity, CancellationToken cancellationToken)
    {
        if (!(entity.Id?.Equals(default) ?? false))
        {
            return Error.Validation(description: $"Id not null");
        }
        await _context.Set<TEntity>().AddAsync(entity);
        return await SaveChangesAsync(entity, cancellationToken);
    }

    public async Task<ErrorOr<TEntity>> Update(TEntity entity, CancellationToken cancellationToken)
    {
        return await Find(entity.Id)
            .Then(oldEntity => oldEntity.Update(entity))
            .ThenAsync(async _ =>
            {
                _context.Set<TEntity>().Update(_);
                return await SaveChangesAsync(_, cancellationToken);
            });
    }

    public async Task<ErrorOr<TEntity>> Upsert(TEntity entity, CancellationToken cancellationToken)
    {
        return await (entity.Id != null).ToErrorOr()
            .MatchAsync(
                async _ => await Update(entity, cancellationToken),
                async _ => await Insert(entity, cancellationToken)
            );
    }

    public async Task<ErrorOr<IEnumerable<TEntity>>> UpsertMany(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
    {
        foreach (var entity in entities)
        {
            if (entity.Id != null)
            {
                _context.Set<TEntity>().Update(entity);
            }
            else
            {
                await _context.Set<TEntity>().AddAsync(entity);
            }
        }
        return await SaveChangesAsync(entities, cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().Where(predicate).ToListAsync();
    }

    protected async Task<ErrorOr<TResult>> SaveChangesAsync<TResult>(TResult response, CancellationToken cancellationToken)
    {
        try
        {
            await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
        catch (Exception ex)
        {
            return Error.Conflict(ex.Message);
        }
    }
}
