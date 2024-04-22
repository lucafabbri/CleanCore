using Clean.Application.Handlers;
using Clean.Examples.CounterWebApp.Domain;
using Clean.Examples.CounterWebApp.Infrastructure;

namespace Clean.Examples.CounterWebApp.Application.Handlers;

public class CreateCounterHandler : CreateEntityCommandHandler<int, Counter, Counter>
{
    public CreateCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

public class ModifyCounterHandler : ModifyEntityCommandHandler<int, Counter, Counter>
{
    public ModifyCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

public class UpsertCounterHandler : UpsertEntityCommandHandler<int, Counter, Counter>
{
    public UpsertCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

public class UpsertManyCounterHandler : UpsertManyEntityCommandHandler<int, Counter, Counter>
{
    public UpsertManyCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

public class DeleteCounterHandler : DeleteEntityCommandHandler<int, Counter, Counter>
{
    public DeleteCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

public class DeleteManyCounterHandler : DeleteManyEntityCommandHandler<int, Counter, Counter>
{
    public DeleteManyCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

public class FindCounterHandler : FindEntityCommandHandler<int, Counter, Counter>
{
    public FindCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

public class FindAllCounterHandler : FindAllEntityCommandHandler<int, Counter, Counter>
{
    public FindAllCounterHandler(CounterDbContext context) : base(context)
    {
    }
}
