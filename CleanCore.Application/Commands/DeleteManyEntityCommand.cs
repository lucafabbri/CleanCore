using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The delete many entity command
/// </summary>
public record DeleteManyEntityCommand<TId, TEntity, TDto>(IEnumerable<TId> Ids) : IRequest<ErrorOr<Deleted>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
