using Clean.Application.DTO;
using Clean.Domain.Events;
using ErrorOr;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.Domain.Common;

public abstract class BaseEntity<TId, TEntity, TDto>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly List<BaseEntityEvent<TId, TEntity, TDto>> _domainEvents = new();


    public BaseEntity(TId? id)
    {
        Id = id;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public TId? Id { get; protected set; }
    public DateTimeOffset CreatedAt { get; protected set; }
    public string? CreatedBy { get; protected set; }
    public DateTimeOffset LastModifiedAt { get; protected set; }
    public string? LastModifiedBy { get; protected set; }
    public DateTimeOffset? DeletedAt { get; protected set; }
    public string? DeletedBy { get; protected set; }
    public bool IsDeleted => DeletedAt != null;

    internal void Created(string? by = "system")
    {
        CreatedAt = DateTimeOffset.Now;
        LastModifiedAt = DateTimeOffset.Now;
        CreatedBy = by;
        LastModifiedBy = by;
        AddDomainEvent(new EntityCreationEvent<TId, TEntity, TDto>(this));
    }

    internal void Modified(string? by = "system")
    {
        LastModifiedAt = DateTimeOffset.Now;
        LastModifiedBy = by;
        AddDomainEvent(new EntityModifiedEvent<TId, TEntity, TDto>(this));
    }

    internal void Deleted(string? by = "system")
    {
        DeletedAt = DateTimeOffset.Now;
        DeletedBy = by;
        AddDomainEvent(new EntityDeletedEvent<TId, TEntity, TDto>(this));
    }

    protected void AddDomainEvent(BaseEntityEvent<TId, TEntity, TDto> domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    protected void RemoveDomainEvent(BaseEntityEvent<TId, TEntity, TDto> domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }

    protected void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public abstract ErrorOr<TEntity> Validate();

    public ErrorOr<TEntity> Update(TEntity entity, string? by = "system")
    {
        return Mutate(_ => _.InnerUpdate(entity), by);
    }

    protected abstract ErrorOr<TEntity> InnerUpdate(TEntity entity);

    internal ErrorOr<TEntity> Mutate(Func<TEntity, ErrorOr<TEntity>> mutation, string? by = "system")
    {
        return this.ToErrorOr()
            .FailIf(entity => entity.IsDeleted, Error.Validation(description: $"Entity {Id} is deleted"))
            .Then(entity => mutation((entity as TEntity)!))
            .Then(result =>
                {
                    Modified(by);
                    return result.Validate();
                });
    }

    public abstract TDto ToDto();
}
