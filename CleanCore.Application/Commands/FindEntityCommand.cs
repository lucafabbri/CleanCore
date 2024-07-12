using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The find entity command
/// </summary>
public class FindEntityCommand<TId, TEntity, TDto> : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{

  /// <summary>
  /// Gets or sets the value of the id
  /// </summary>
  public TId Id { get; set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="FindEntityCommand{TId,TEntity,TDto}"/> class
  /// </summary>
  /// <param name="id">The id</param>
  public FindEntityCommand(TId id)
  {
    Id = id;
  }
}
