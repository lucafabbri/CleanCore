using Clean.Application.DTO;
using Clean.Domain.Common;
using ErrorOr;
using System.Linq.Expressions;

namespace Clean.Application.Persistence
{
    public interface IEntityRepository<TId, TEntity, TDto>
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto: IEntityDto<TId, TEntity, TDto>
    {

        Task<ErrorOr<TEntity>> Find(TId? id);
        Task<IEnumerable<TEntity>> FindAll();
        IQueryable<TEntity> AsQueryable();
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<ErrorOr<TEntity>> Insert(TEntity entity, CancellationToken cancellationToken);
        Task<ErrorOr<TEntity>> Update(TEntity entity, CancellationToken cancellationToken);
        Task<ErrorOr<TEntity>> Upsert(TEntity entity, CancellationToken cancellationToken);
        Task<ErrorOr<IEnumerable<TEntity>>> UpsertMany(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
        Task<ErrorOr<TEntity>> Delete(TEntity entity, CancellationToken cancellationToken);
        Task<ErrorOr<Deleted>> DeleteMany(IEnumerable<TEntity> entities, CancellationToken cancellationToken);
    }
}
