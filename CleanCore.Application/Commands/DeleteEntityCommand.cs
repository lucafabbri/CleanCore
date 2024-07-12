using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The delete entity command
/// </summary>
public class DeleteEntityCommand<TId, TEntity, TDto> : IRequest<ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
  /// <summary>
  /// Gets or sets the value of the id
  /// </summary>
  public TId Id { get; set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="DeleteEntityCommand{TId,TEntity,TDto}"/> class
  /// </summary>
  /// <param name="id">The id</param>
  public DeleteEntityCommand(TId id)
  {
    Id = id;
  }
}
