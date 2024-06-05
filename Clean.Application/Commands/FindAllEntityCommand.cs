using Clean.Domain.Common;
using MediatR;

namespace Clean.Application.Commands;

/// <summary>
/// The find all entity command
/// </summary>
public record FindAllEntityCommand<TId, TEntity, TDto>() : IRequest<IEnumerable<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
