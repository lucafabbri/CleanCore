using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;
/// <summary>
/// The create entity command
/// </summary>
public record CreateEntityCommand<TId, TEntity, TDto>(ICreateEntityDto<TId, TEntity, TDto> Dto) : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>;
