using Clean.Domain.Common;
using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.DTO
{
    public interface ICreateEntityDto<TId, TEntity,TDto>
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        TId? Id { get; set; }
        TEntity ToEntity();
    }
}
