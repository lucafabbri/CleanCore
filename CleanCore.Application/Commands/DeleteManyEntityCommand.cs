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
  public IEnumerable<TId> Ids { get; set; }

  public DeleteManyEntityCommand(IEnumerable<TId> ids)
  {
    Ids = ids;
  }
}
