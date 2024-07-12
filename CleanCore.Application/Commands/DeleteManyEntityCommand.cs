using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The delete many entity command
/// </summary>
public class DeleteManyEntityCommand<TId, TEntity, TDto> : IRequest<ErrorOr<Deleted>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
  /// <summary>
  /// Gets or sets the value of the ids
  /// </summary>
  public IEnumerable<TId> Ids { get; set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="DeleteManyEntityCommand{TId,TEntity,TDto}"/> class
  /// </summary>
  /// <param name="ids">The ids</param>
  public DeleteManyEntityCommand(IEnumerable<TId> ids)
  {
    Ids = ids;
  }
}
