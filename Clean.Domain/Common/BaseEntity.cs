using ErrorOr;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.Domain.Common;

public abstract class BaseEntity
{

    protected readonly List<BaseEntityEvent> _domainEvents = new();

    [NotMapped]
    public IReadOnlyCollection<BaseEntityEvent> DomainEvents => _domainEvents.AsReadOnly();
    public DateTimeOffset CreatedAt { get; protected set; }
    public string? CreatedBy { get; protected set; }
    public DateTimeOffset LastModifiedAt { get; protected set; }
    public string? LastModifiedBy { get; protected set; }
    public DateTimeOffset? DeletedAt { get; protected set; }
    public string? DeletedBy { get; protected set; }
    public bool IsDeleted => DeletedAt != null;

    public virtual void Created(string? by = "system", DateTimeOffset? when = null)
    {
        CreatedAt = when??DateTimeOffset.Now;
        LastModifiedAt = when ?? DateTimeOffset.Now;
        CreatedBy = by;
        LastModifiedBy = by;
    }

    public virtual void Modified(string? by = "system", DateTimeOffset? when = null)
    {
        LastModifiedAt = when ?? DateTimeOffset.Now;
        LastModifiedBy = by;
    }

    public virtual void Deleted(string? by = "system", DateTimeOffset? when = null)
    {
        DeletedAt = when ?? DateTimeOffset.Now;
        DeletedBy = by;
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}

public abstract class BaseEntity<TId, TEntity, TDto>:BaseEntity
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    public BaseEntity()
    {
    }

    public BaseEntity(TId? id)
    {
        Id = id;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public TId? Id { get; protected set; }

    public abstract ErrorOr<TEntity> Validate();

    public ErrorOr<TEntity> Update(TEntity entity)
    {
        return Mutate(_ => _.InnerUpdate(entity));
    }

    protected abstract ErrorOr<TEntity> InnerUpdate(TEntity entity);

    internal ErrorOr<TEntity> Mutate(Func<TEntity, ErrorOr<TEntity>> mutation)
    {
        return this.ToErrorOr()
            .FailIf(entity => entity.IsDeleted, Error.Validation(description: $"Entity {Id} is deleted"))
            .Then(entity => mutation((entity as TEntity)!))
            .Then(result =>
                {
                    return result.Validate();
                });
    }

    public ErrorOr<TEntity> AddDomainEvent(BaseEntityEvent<TId, TEntity, TDto> domainEvent)
    {
        _domainEvents.Add(domainEvent);
        return (this as TEntity)!;
    }

    public ErrorOr<TEntity> RemoveDomainEvent(BaseEntityEvent<TId, TEntity, TDto> domainEvent)
    {
        _domainEvents.Remove(domainEvent);
        return (this as TEntity)!;
    }

    public abstract TDto ToDto();
}
