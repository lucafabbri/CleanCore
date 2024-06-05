using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The upsert entity command
/// </summary>
public record UpsertEntityCommand<TId, TEntity, TDto>(TDto Dto) : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
