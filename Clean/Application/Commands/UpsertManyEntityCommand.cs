using Clean.Application.DTO;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public record UpsertManyEntityCommand<TId, TEntity, TDto>(IEnumerable<TDto> Dtos) : IRequest<ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
