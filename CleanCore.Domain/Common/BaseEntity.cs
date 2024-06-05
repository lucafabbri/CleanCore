using ErrorOr;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanCore.Domain.Common;

/// <summary>
/// The base entity class
/// </summary>
public abstract class BaseEntity
{

    /// <summary>
    /// The domain events
    /// </summary>
    protected readonly List<BaseEntityEvent> _domainEvents = new();

    /// <summary>
    /// Gets the value of the domain events
    /// </summary>
    [NotMapped]
    public IReadOnlyCollection<BaseEntityEvent> DomainEvents => _domainEvents.AsReadOnly();
    /// <summary>
    /// Gets or sets the value of the created at
    /// </summary>
    public DateTimeOffset CreatedAt { get; protected set; }
    /// <summary>
    /// Gets or sets the value of the created by
    /// </summary>
    public string? CreatedBy { get; protected set; }
    /// <summary>
    /// Gets or sets the value of the last modified at
    /// </summary>
    public DateTimeOffset LastModifiedAt { get; protected set; }
    /// <summary>
    /// Gets or sets the value of the last modified by
    /// </summary>
    public string? LastModifiedBy { get; protected set; }
    /// <summary>
    /// Gets or sets the value of the deleted at
    /// </summary>
    public DateTimeOffset? DeletedAt { get; protected set; }
    /// <summary>
    /// Gets or sets the value of the deleted by
    /// </summary>
    public string? DeletedBy { get; protected set; }
    /// <summary>
    /// Gets the value of the is deleted
    /// </summary>
    public bool IsDeleted => DeletedAt != null;

    /// <summary>
    /// Createds the by
    /// </summary>
    /// <param name="by">The by</param>
    /// <param name="when">The when</param>
    public virtual void Created(string? by = "system", DateTimeOffset? when = null)
    {
        CreatedAt = when??DateTimeOffset.Now;
        LastModifiedAt = when ?? DateTimeOffset.Now;
        CreatedBy = by;
        LastModifiedBy = by;
    }

    /// <summary>
    /// Modifieds the by
    /// </summary>
    /// <param name="by">The by</param>
    /// <param name="when">The when</param>
    public virtual void Modified(string? by = "system", DateTimeOffset? when = null)
    {
        LastModifiedAt = when ?? DateTimeOffset.Now;
        LastModifiedBy = by;
    }

    /// <summary>
    /// Deleteds the by
    /// </summary>
    /// <param name="by">The by</param>
    /// <param name="when">The when</param>
    public virtual void Deleted(string? by = "system", DateTimeOffset? when = null)
    {
        DeletedAt = when ?? DateTimeOffset.Now;
        DeletedBy = by;
    }

    /// <summary>
    /// Clears the domain events
    /// </summary>
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}

/// <summary>
/// The base entity class
/// </summary>
/// <seealso cref="BaseEntity"/>
public abstract class BaseEntity<TId, TEntity, TDto>:BaseEntity
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity{TId,TEntity,TDto}"/> class
    /// </summary>
    public BaseEntity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="id">The id</param>
    public BaseEntity(TId? id)
    {
        Id = id;
    }

    /// <summary>
    /// Gets or sets the value of the id
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public TId? Id { get; set; }

    /// <summary>
    /// Validates this instance
    /// </summary>
    /// <returns>An error or of t entity</returns>
    public abstract ErrorOr<TEntity> Validate();

    /// <summary>
    /// Updates the entity
    /// </summary>
    /// <param name="entity">The entity</param>
    /// <returns>An error or of t entity</returns>
    public ErrorOr<TEntity> Update(TEntity entity)
    {
        return Mutate(_ => _.InnerUpdate(entity));
    }

    /// <summary>
    /// Inners the update using the specified entity
    /// </summary>
    /// <param name="entity">The entity</param>
    /// <returns>An error or of t entity</returns>
    protected abstract ErrorOr<TEntity> InnerUpdate(TEntity entity);

    /// <summary>
    /// Mutates the mutation
    /// </summary>
    /// <param name="mutation">The mutation</param>
    /// <returns>An error or of t entity</returns>
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

    /// <summary>
    /// Adds the domain event using the specified domain event
    /// </summary>
    /// <param name="domainEvent">The domain event</param>
    /// <returns>An error or of t entity</returns>
    public ErrorOr<TEntity> AddDomainEvent(BaseEntityEvent<TId, TEntity, TDto> domainEvent)
    {
        _domainEvents.Add(domainEvent);
        return (this as TEntity)!;
    }

    /// <summary>
    /// Removes the domain event using the specified domain event
    /// </summary>
    /// <param name="domainEvent">The domain event</param>
    /// <returns>An error or of t entity</returns>
    public ErrorOr<TEntity> RemoveDomainEvent(BaseEntityEvent<TId, TEntity, TDto> domainEvent)
    {
        _domainEvents.Remove(domainEvent);
        return (this as TEntity)!;
    }

    /// <summary>
    /// Returns the dto
    /// </summary>
    /// <returns>The dto</returns>
    public abstract TDto ToDto();
}

/// <summary>
/// The base entity and dto class
/// </summary>
/// <seealso cref="BaseEntity{TId, TEntity, TEntity}"/>
/// <seealso cref="IEntityDto{TId, TEntity, TEntity}"/>
/// <seealso cref="ICreateEntityDto{TId, TEntity, TEntity}"/>
public abstract class BaseEntityAndDto<TId, TEntity> : BaseEntity<TId, TEntity, TEntity>, IEntityDto<TId, TEntity, TEntity>, ICreateEntityDto<TId, TEntity, TEntity>
    where TId : IEquatable<TId>
    where TEntity : BaseEntityAndDto<TId, TEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntityAndDto{TId,TEntity}"/> class
    /// </summary>
    protected BaseEntityAndDto()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntityAndDto{TId,TEntity}"/> class
    /// </summary>
    /// <param name="id">The id</param>
    protected BaseEntityAndDto(TId? id) : base(id)
    {
    }

    /// <summary>
    /// Returns the dto
    /// </summary>
    /// <returns>The entity</returns>
    public override TEntity ToDto()
    {
        return (this as TEntity)!;
    }

    /// <summary>
    /// Returns the entity
    /// </summary>
    /// <returns>The entity</returns>
    public TEntity ToEntity()
    {
        return (this as TEntity)!;
    }
}

/// <summary>
/// The base int entity class
/// </summary>
/// <seealso cref="BaseEntity{Int, TEntity, TDto}"/>
public abstract class BaseIntEntity<TEntity, TDto> : BaseEntity<int, TEntity, TDto>
    where TEntity : BaseEntity<int, TEntity, TDto>
    where TDto : IEntityDto<int, TEntity, TDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseIntEntity{TEntity,TDto}"/> class
    /// </summary>
    protected BaseIntEntity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseIntEntity{TEntity,TDto}"/> class
    /// </summary>
    /// <param name="id">The id</param>
    protected BaseIntEntity(int id) : base(id)
    {
    }
}

/// <summary>
/// The base int entity and dto class
/// </summary>
/// <seealso cref="BaseEntityAndDto{Int, TEntity}"/>
public abstract class BaseIntEntityAndDto<TEntity> : BaseEntityAndDto<int, TEntity>
    where TEntity : BaseEntityAndDto<int, TEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseIntEntityAndDto{TEntity}"/> class
    /// </summary>
    protected BaseIntEntityAndDto()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseIntEntityAndDto{TEntity}"/> class
    /// </summary>
    /// <param name="id">The id</param>
    protected BaseIntEntityAndDto(int id) : base(id)
    {
    }
}
