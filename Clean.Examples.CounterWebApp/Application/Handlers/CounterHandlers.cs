using Clean.Application.Handlers;
using Clean.Application.Persistence;
using Clean.Examples.CounterWebApp.Domain;

namespace Clean.Examples.CounterWebApp.Application.Handlers;

public class CreateCounterHandler : CreateEntityCommandHandler<int, Counter, CounterDto>
{
    public CreateCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}

public class ModifyCounterHandler : ModifyEntityCommandHandler<int, Counter, CounterDto>
{
    public ModifyCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}

public class UpsertCounterHandler : UpsertEntityCommandHandler<int, Counter, CounterDto>
{
    public UpsertCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}

public class UpsertManyCounterHandler : UpsertManyEntityCommandHandler<int, Counter, CounterDto>
{
    public UpsertManyCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}

public class DeleteCounterHandler : DeleteEntityCommandHandler<int, Counter, CounterDto>
{
    public DeleteCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}

public class DeleteManyCounterHandler : DeleteManyEntityCommandHandler<int, Counter, CounterDto>
{
    public DeleteManyCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}

public class FindCounterHandler : FindEntityCommandHandler<int, Counter, CounterDto>
{
    public FindCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}

public class FindAllCounterHandler : FindAllEntityCommandHandler<int, Counter, CounterDto>
{
    public FindAllCounterHandler(IEntityRepository<int, Counter, CounterDto> context) : base(context)
    {
    }
}
