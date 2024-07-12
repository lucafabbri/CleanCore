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
  /// <summary>
  /// Gets or sets the value of the dto
  /// </summary>
  public ICreateEntityDto<TId, TEntity, TDto> Dto { get; set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="CreateEntityCommand{TId,TEntity,TDto}"/> class
  /// </summary>
  /// <param name="dto">The dto</param>
  public CreateEntityCommand(ICreateEntityDto<TId, TEntity, TDto> dto)
  {
    Dto = dto;
  }
}
