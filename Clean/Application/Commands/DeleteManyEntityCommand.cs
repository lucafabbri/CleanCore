using Clean.Application.DTO;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public record DeleteManyEntityCommand<TId, TEntity, TDto>(IEnumerable<TId> Ids) : IRequest<ErrorOr<Deleted>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
