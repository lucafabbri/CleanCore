namespace Clean.Domain.Common;

public interface IEntityDto<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    TId? Id { get; }
    DateTimeOffset CreatedAt { get; }
    string? CreatedBy { get; }
    DateTimeOffset LastModifiedAt { get; }
    string? LastModifiedBy { get; }
    DateTimeOffset? DeletedAt { get; }
    string? DeletedBy { get; }
    TEntity ToEntity();
}

public abstract class EntityDto<TId, TEntity, TDto>:IEntityDto<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    public TId? Id { get; }
    public DateTimeOffset CreatedAt { get; }
    public string? CreatedBy { get; }
    public DateTimeOffset LastModifiedAt { get; }
    public string? LastModifiedBy { get; }
    public DateTimeOffset? DeletedAt { get; }
    public string? DeletedBy { get; }
    public abstract TEntity ToEntity();
}
