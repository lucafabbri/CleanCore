using CleanCore.Domain.Common;
using ErrorOr;
using MediatR;

namespace CleanCore.Application.Commands;

/// <summary>
/// The upsert many entity command
/// </summary>
public class UpsertManyEntityCommand<TId, TEntity, TDto> : IRequest<ErrorOr<IEnumerable<TDto>>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
  /// <summary>
  /// Gets or sets the value of the dtos
  /// </summary>
  public IEnumerable<TDto> Dtos { get; set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="UpsertManyEntityCommand{TId,TEntity,TDto}"/> class
  /// </summary>
  /// <param name="dtos">The dtos</param>
  public UpsertManyEntityCommand(IEnumerable<TDto> dtos)
  {
    Dtos = dtos;
  }
}
