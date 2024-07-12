using CleanCore.Domain.Common;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The find all entity command
/// </summary>
public class FindAllEntityCommand<TId, TEntity, TDto> : IRequest<IEnumerable<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
