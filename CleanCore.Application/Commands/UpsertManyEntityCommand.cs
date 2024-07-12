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
  public IEnumerable<TDto> Dtos { get; set; }

  public UpsertManyEntityCommand(IEnumerable<TDto> dtos)
  {
    Dtos = dtos;
  }
}
