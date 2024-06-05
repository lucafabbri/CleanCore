using Clean.Application.Handlers;
using Clean.Examples.CounterWebApp.Domain;
using Clean.Examples.CounterWebApp.Infrastructure;

namespace Clean.Examples.CounterWebApp.Application.Handlers;

/// <summary>
/// The create counter handler class
/// </summary>
/// <seealso cref="CreateEntityCommandHandler{Int, Counter, Counter}"/>
public class CreateCounterHandler : CreateEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public CreateCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

/// <summary>
/// The modify counter handler class
/// </summary>
/// <seealso cref="ModifyEntityCommandHandler{Int, Counter, Counter}"/>
public class ModifyCounterHandler : ModifyEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ModifyCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public ModifyCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

/// <summary>
/// The upsert counter handler class
/// </summary>
/// <seealso cref="UpsertEntityCommandHandler{Int, Counter, Counter}"/>
public class UpsertCounterHandler : UpsertEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpsertCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public UpsertCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

/// <summary>
/// The upsert many counter handler class
/// </summary>
/// <seealso cref="UpsertManyEntityCommandHandler{Int, Counter, Counter}"/>
public class UpsertManyCounterHandler : UpsertManyEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpsertManyCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public UpsertManyCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

/// <summary>
/// The delete counter handler class
/// </summary>
/// <seealso cref="DeleteEntityCommandHandler{Int, Counter, Counter}"/>
public class DeleteCounterHandler : DeleteEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public DeleteCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

/// <summary>
/// The delete many counter handler class
/// </summary>
/// <seealso cref="DeleteManyEntityCommandHandler{Int, Counter, Counter}"/>
public class DeleteManyCounterHandler : DeleteManyEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteManyCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public DeleteManyCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

/// <summary>
/// The find counter handler class
/// </summary>
/// <seealso cref="FindEntityCommandHandler{Int, Counter, Counter}"/>
public class FindCounterHandler : FindEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FindCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public FindCounterHandler(CounterDbContext context) : base(context)
    {
    }
}

/// <summary>
/// The find all counter handler class
/// </summary>
/// <seealso cref="FindAllEntityCommandHandler{Int, Counter, Counter}"/>
public class FindAllCounterHandler : FindAllEntityCommandHandler<int, Counter, Counter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FindAllCounterHandler"/> class
    /// </summary>
    /// <param name="context">The context</param>
    public FindAllCounterHandler(CounterDbContext context) : base(context)
    {
    }
}
