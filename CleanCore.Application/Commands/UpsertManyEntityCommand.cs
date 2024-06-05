using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The upsert many entity command
/// </summary>
public record UpsertManyEntityCommand<TId, TEntity, TDto>(IEnumerable<TDto> Dtos) : IRequest<ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
