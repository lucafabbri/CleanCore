using Clean.Application.Commands;
using Clean.Domain.Common;
using ErrorOr;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clean.Application.Handlers;

public abstract class FindEntityCommandHandler<TId, TEntity, TDto> : IRequestHandler<FindEntityCommand<TId, TEntity, TDto>, ErrorOr<TDto>>
    where TId : IEquatable<TId>
    where TEntity : BaseEntity<TId, TEntity, TDto>
    where TDto : IEntityDto<TId, TEntity, TDto>
{
    private readonly DbContext _context;

    public FindEntityCommandHandler(DbContext context)
    {
        _context = context;
    }

    public virtual async Task<ErrorOr<TDto>> Handle(FindEntityCommand<TId, TEntity, TDto> request, CancellationToken cancellationToken)
    {
        return (await _context.Set<TEntity>().FindAsync(request.Id))
            .ToErrorOr()
            .FailIf(_ => _ == null, Error.NotFound(description: $"{request.Id} not found"))
            .Then(entity => entity!.ToDto());
    }
}
