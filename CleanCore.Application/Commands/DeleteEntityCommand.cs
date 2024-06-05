using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The delete entity command
/// </summary>
public record DeleteEntityCommand<TId, TEntity, TDto>(TId Id) : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
