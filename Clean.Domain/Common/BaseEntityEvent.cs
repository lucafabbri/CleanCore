using MediatR;

namespace Clean.Domain.Common;

public class BaseEntityEvent<TId, TEntity, TDto> : BaseEntityEvent
where TId : IEquatable<TId>
where TEntity : BaseEntity<TId, TEntity, TDto>
where TDto : IEntityDto<TId, TEntity, TDto>
{
    public BaseEntityEvent(BaseEntity<TId, TEntity, TDto> entity)
    {
        Entity = (entity as TEntity)!;
    }
    public TEntity Entity { get; set; }
}

public class BaseEntityEvent : INotification
{

}
