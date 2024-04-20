using Clean.Application.DTO;
using Clean.Application.Persistence;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;

namespace Clean.Application.Commands;

public class DeleteEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<DeleteEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly IEntityContext<TId, TEntity, TDto> _context;

    public DeleteEntityCommandHandler(IEntityContext<TId, TEntity, TDto> context)
    {
        _context = context;
    }

    public async Task<ErrorOr<TDto>> Handle(DeleteEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return await _context.Delete(request.Id, cancellationToken)
            .Then(entity => entity.ToDto());
    }
}