using Clean.Application.DTO;
using Clean.Domain.Common;

namespace Clean.Domain.Events;

public class EntityModifiedEvent<TId, TEntity, TDto> : BaseEntityEvent<TId, TEntity, TDto>
where TId : IEquatable<TId>
where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    public EntityModifiedEvent(BaseEntity<TId, TEntity, TDto> entity) : base(entity)
    {
    }
}
