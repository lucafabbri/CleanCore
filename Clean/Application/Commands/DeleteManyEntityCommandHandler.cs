using Clean.Application.DTO;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public class DeleteManyEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<DeleteManyEntityCommand<TId, TEntity, TDto>, ErrorOr<Deleted>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityContext<TId, TEntity, TDto> _context;

    public DeleteManyEntityCommandHandler(IEntityContext<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public async Task<ErrorOr<Deleted>> Handle(DeleteManyEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await _context.DeleteMany(request.Ids, cancellationToken);
    }
}
