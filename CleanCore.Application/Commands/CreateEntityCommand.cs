using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;
/// <summary>
/// The create entity command
/// </summary>
public class CreateEntityCommand<TId, TEntity, TDto> : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
  public ICreateEntityDto<TId, TEntity, TDto> Dto { get; set; }

  public CreateEntityCommand(ICreateEntityDto<TId, TEntity, TDto> dto)
  {
    Dto = dto;
  }
}
