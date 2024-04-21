using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public record UpsertEntityCommand<TId, TEntity, TDto>(TDto Dto) : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
