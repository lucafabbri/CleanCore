using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The upsert entity command
/// </summary>
public class UpsertEntityCommand<TId, TEntity, TDto> : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
  /// <summary>
  /// Gets or sets the value of the dto
  /// </summary>
  public TDto Dto { get; set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="UpsertEntityCommand{TId,TEntity,TDto}"/> class
  /// </summary>
  /// <param name="dto">The dto</param>
  public UpsertEntityCommand(TDto dto)
  {
    Dto = dto;
  }
}
