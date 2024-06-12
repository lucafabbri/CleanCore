using CleanCore.Application.Handlers;
using CleanCore.Application.Services;
using CleanCore.Examples.CounterWebApp.Domain;
using CleanCore.Examples.CounterWebApp.DTO;
using CleanCore.Examples.CounterWebApp.Infrastructure;

namespace CleanCore.Examples.CounterElasticWebApp.Application.Handlers;

/// <summary>
/// The create counter handler class
/// </summary>
/// <seealso cref="CreateElasticEntityCommandHandler{String, ElasticCounter, ElasticCounterDto}"/>
public class CreateCounterHandler : CreateElasticEntityCommandHandler<string, ElasticCounter, ElasticCounterDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCounterHandler"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    public CreateCounterHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }
}

/// <summary>
/// The modify counter handler class
/// </summary>
/// <seealso cref="ModifyElasticEntityCommandHandler{String, ElasticCounter, ElasticCounterDto}"/>
public class ModifyCounterHandler : ModifyElasticEntityCommandHandler<string, ElasticCounter, ElasticCounterDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ModifyCounterHandler"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    public ModifyCounterHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }
}

/// <summary>
/// The upsert counter handler class
/// </summary>
/// <seealso cref="UpsertElasticEntityCommandHandler{String, ElasticCounter, ElasticCounterDto}"/>
public class UpsertCounterHandler : UpsertElasticEntityCommandHandler<string, ElasticCounter, ElasticCounterDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpsertCounterHandler"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    public UpsertCounterHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }
}

/// <summary>
/// The delete counter handler class
/// </summary>
/// <seealso cref="DeleteElasticEntityCommandHandler{String, ElasticCounter, ElasticCounterDto}"/>
public class DeleteCounterHandler : DeleteElasticEntityCommandHandler<string, ElasticCounter, ElasticCounterDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteCounterHandler"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    public DeleteCounterHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }
}

/// <summary>
/// The delete many counter handler class
/// </summary>
/// <seealso cref="DeleteManyElasticEntityCommandHandler{String, ElasticCounter, ElasticCounterDto}"/>
public class DeleteManyCounterHandler : DeleteManyElasticEntityCommandHandler<string, ElasticCounter, ElasticCounterDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteManyCounterHandler"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    public DeleteManyCounterHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }
}

/// <summary>
/// The find counter handler class
/// </summary>
/// <seealso cref="FindElasticEntityCommandHandler{String, ElasticCounter, ElasticCounterDto}"/>
public class FindCounterHandler : FindElasticEntityCommandHandler<string, ElasticCounter, ElasticCounterDto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FindCounterHandler"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    public FindCounterHandler(IConfiguration configuration, IUserProvider userProvider) : base(configuration, userProvider)
    {
    }
}
