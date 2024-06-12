using CleanCore.Application.Services;
using CleanCore.Core.Extensions;
using CleanCore.Domain.Common;
using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.QueryDsl;
using Elastic.Transport;
using ErrorOr;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CleanCore.Application.Handlers;

/// <summary>
/// The base elastic command handler class
/// </summary>
public abstract class BaseElasticCommandHandler<TId, TEntity, TDto>
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
{
    /// <summary>
    /// Gets the value of the index
    /// </summary>
    protected string Index => $"idx_{typeof(TEntity).Name.ToLower()}";

    /// <summary>
    /// The configuration
    /// </summary>
    protected readonly IConfiguration configuration;
    /// <summary>
    /// The user provider
    /// </summary>
    private readonly IUserProvider userProvider;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseElasticCommandHandler{TId,TEntity,TDto}"/> class
    /// </summary>
    /// <param name="configuration">The configuration</param>
    /// <param name="userProvider">The user provider</param>
    protected BaseElasticCommandHandler(IConfiguration configuration, IUserProvider userProvider)
    {
        this.configuration = configuration;
        this.userProvider = userProvider;
    }

    /// <summary>
    /// Gets the elastic client
    /// </summary>
    /// <returns>The client</returns>
    protected ElasticsearchClient GetElasticClient()
    {
        var url = configuration["ElasticSearch:Url"] ?? "http://localhost:9200";
        var user = configuration["ElasticSearch:User"] ?? "elastic";
        var pwd = configuration["ElasticSearch:Password"] ?? "changeme";

        var client = new ElasticsearchClient(new ElasticsearchClientSettings(uri: new Uri(url)).Authentication(new BasicAuthentication(user, pwd)));

        return client;
    }

    /// <summary>
    /// Searches the index
    /// </summary>
    /// <param name="query">The query</param>
    /// <param name="from">The from</param>
    /// <param name="size">The size</param>
    /// <returns>A task containing an enumerable of t entity</returns>
    protected async Task<IEnumerable<TEntity>> SearchAsync(Query query, int from = 0, int size = 10)
    {
        var client = GetElasticClient();

        var searchRequest = new SearchRequest(Index)
        {
            From = from,
            Size = size,
            Query = query
        };

        var response = await client.SearchAsync<TEntity>(searchRequest);

        if (response.IsValidResponse)
        {
            return response.Documents;
        }

        return Enumerable.Empty<TEntity>();
    }

    /// <summary>
    /// Indexes the index
    /// </summary>
    /// <param name="entity">The entity</param>
    /// <returns>A task containing an error or of t entity</returns>
    protected async Task<ErrorOr<TEntity>> IndexAsync(TEntity entity)
    {
        var client = GetElasticClient();

        entity.Created(by: userProvider.GetCurrentUser().ValueOrNull()?.Name, when: DateTime.UtcNow);

        var response = await client.IndexAsync(document: entity, index: Index);

        if (response.IsValidResponse)
        {
            return entity;
        }

        return Error.Conflict();
    }

    /// <summary>
    /// Indexes the many using the specified index
    /// </summary>
    /// <param name="entities">The entities</param>
    /// <returns>A task containing an error or of i enumerable t entity</returns>
    protected async Task<ErrorOr<IEnumerable<TEntity>>> IndexManyAsync(IEnumerable<TEntity> entities)
    {
        var client = GetElasticClient();

        var response = await client.IndexManyAsync(objects: entities.Select(e =>
        {
            e.Created(by: userProvider.GetCurrentUser().ValueOrNull()?.Name, when: DateTime.UtcNow);
            return e;
        }).ToList(), index: Index);

        if (response.IsValidResponse)
        {
            return entities.ToList();
        }

        return Error.Conflict();
    }

    /// <summary>
    /// Gets the index
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an error or of t entity</returns>
    protected async Task<ErrorOr<TEntity>> GetAsync(TId id)
    {
        var client = GetElasticClient();
        var request = new GetRequest(index: Index, id: new Id(new { Id = id } as TEntity));
        var response = await client.GetAsync<TEntity>(request);

        if (response != null && response.IsValidResponse && response.Source != null)
        {
            return response.Source;
        }

        return Error.NotFound();
    }

    /// <summary>
    /// Updates the index
    /// </summary>
    /// <param name="entity">The entity</param>
    /// <returns>A task containing an error or of t entity</returns>
    protected async Task<ErrorOr<TEntity>> UpdateAsync(TEntity entity)
    {
        var client = GetElasticClient();

        entity.Modified(by: userProvider.GetCurrentUser().ValueOrNull()?.Name, when: DateTime.UtcNow);

        var response = await client.UpdateAsync<TEntity, TEntity>(id: new Id(entity), index: Index, configureRequest: u => u.Doc(entity));

        if (response.IsValidResponse)
        {
            return entity;
        }

        return Error.Conflict();
    }

    /// <summary>
    /// Deletes the index
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>A task containing an error or of deleted</returns>
    protected async Task<ErrorOr<Deleted>> DeleteAsync(TId id)
    {
        var client = GetElasticClient();

        var response = await client.DeleteAsync(id: new Id(new { Id = 10 } as TEntity), index: Index);

        if (response.IsValidResponse)
        {
            return ErrorOr.Result.Deleted;
        }

        return Error.Conflict();
    }

    /// <summary>
    /// Deletes the many using the specified index
    /// </summary>
    /// <param name="ids">The ids</param>
    /// <returns>A task containing an error or of deleted</returns>
    protected async Task<ErrorOr<Deleted>> DeleteManyAsync(IEnumerable<TId> ids)
    {
        var client = GetElasticClient();

        var elasticIds = new Ids(ids.Select(id => new Id(id)).ToList());

        var response = await client.DeleteByQueryAsync<TEntity>(Index, d => d.Query(q => q.Ids(i => i.Values(elasticIds))));

        if (response.IsValidResponse)
        {
            return ErrorOr.Result.Deleted;
        }

        return Error.Conflict();
    }
}
