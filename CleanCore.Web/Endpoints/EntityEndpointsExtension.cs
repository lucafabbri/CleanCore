
using CleanCore.Application.Commands;
using CleanCore.Domain.Common;
using CleanCore.Web.Extensions;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CleanCore.Web.Endpoints;

/// <summary>
/// The entity endpoints extension class
/// </summary>
public static class EntityEndpointsExtension
{
    /// <summary>
    /// Maps the entity using the specified builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="prefix">the prefix</param>
    /// <param name="versions">The versions</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder MapEntity<TEntity>(this IEndpointRouteBuilder builder, string prefix = "api", params int[] versions)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.MapEntity<int, TEntity>(prefix, versions);
    }
    /// <summary>
    /// Maps the entity using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="prefix">the prefix</param>
    /// <param name="versions">The versions</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder MapEntity<TId, TEntity>(this IEndpointRouteBuilder builder, string prefix = "api", params int[] versions)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.MapEntity<TId, TEntity, TEntity, TEntity>(prefix, versions);
    }

    /// <summary>
    /// Maps the entity using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <typeparam name="TCreateDto">The create dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="prefix">the prefix</param>
    /// <param name="versions">The versions</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder MapEntity<TId, TEntity, TDto, TCreateDto>(this IEndpointRouteBuilder builder, string prefix = "api", params int[] versions)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        var groupName = typeof(TEntity).Name;
        var result = builder.NewVersionedApi(groupName)
            .MapGroup($"/{prefix.ToLowerInvariant()}/{groupName.ToLowerInvariant()}")
            .WithTags(groupName);
        foreach (var version in versions)
        {
            result.HasApiVersion(version);
        }
        return result.WithOpenApi();
    }

    /// <summary>
    /// Alls the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder All<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder
            .FindAll<TEntity>(version)
            .Find<TEntity>(version)
            .Create<TEntity>(version)
            .Modify<TEntity>(version)
            .Upsert<TEntity>(version)
            .UpsertMany<TEntity>(version)
            .Delete<TEntity>(version)
            .DeleteMany<TEntity>(version);
    }

    /// <summary>
    /// Alls the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder All<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder
            .FindAll<TId, TEntity>(version)
            .Find<TId, TEntity>(version)
            .Create<TId, TEntity>(version)
            .Modify<TId, TEntity>(version)
            .Upsert<TId, TEntity>(version)
            .UpsertMany<TId, TEntity>(version)
            .Delete<TId, TEntity>(version)
            .DeleteMany<TId, TEntity>(version);
    }

    /// <summary>
    /// Alls the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <typeparam name="TCreateDto">The create dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder All<TId, TEntity, TDto, TCreateDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        return builder
            .FindAll<TId, TEntity, TDto>(version)
            .Find<TId, TEntity, TDto>(version)
            .Create<TId, TEntity, TDto, TCreateDto>(version)
            .Modify<TId, TEntity, TDto>(version)
            .Upsert<TId, TEntity, TDto>(version)
            .UpsertMany<TId, TEntity, TDto>(version)
            .Delete<TId, TEntity, TDto>(version)
            .DeleteMany<TId, TEntity, TDto>(version);
    }

    /// <summary>
    /// Finds the all using the specified builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder FindAll<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.FindAll<int, TEntity>(version);
    }

    /// <summary>
    /// Finds the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Find<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Find<int, TEntity>(version);
    }

    /// <summary>
    /// Creates the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Create<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Create<int, TEntity>(version);
    }

    /// <summary>
    /// Modifies the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Modify<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Modify<int, TEntity>(version);
    }

    /// <summary>
    /// Upserts the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Upsert<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Upsert<int, TEntity>(version);
    }

    /// <summary>
    /// Upserts the many using the specified builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder UpsertMany<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.UpsertMany<int, TEntity>(version);
    }

    /// <summary>
    /// Deletes the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Delete<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Delete<int, TEntity>(version);
    }

    /// <summary>
    /// Deletes the many using the specified builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder DeleteMany<TEntity>(this RouteGroupBuilder builder, int version)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.DeleteMany<int, TEntity>(version);
    }

    /// <summary>
    /// Finds the all using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder FindAll<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.FindAll<TId, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Finds the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Find<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Find<TId, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Creates the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Create<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Create<TId, TEntity, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Modifies the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Modify<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Modify<TId, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Upserts the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Upsert<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Upsert<TId, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Upserts the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder UpsertMany<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.UpsertMany<TId, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Deletes the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Delete<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Delete<TId, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Deletes the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder DeleteMany<TId, TEntity>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.DeleteMany<TId, TEntity, TEntity>(version);
    }

    /// <summary>
    /// Finds the all using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder FindAll<TId, TEntity, TDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapGet("/", async ([FromServices] ISender sender) =>
        {
            return await sender.Send(new FindAllEntityCommand<TId, TEntity, TDto>());
        })
            .Produces<IEnumerable<TDto>>(200)
            .Produces<Error>(400)
            .Produces<Error>(401)
            .Produces<Error>(403)
            .Produces<Error>(404)
            .Produces<Error>(422)
            .MapToApiVersion(version);

        return builder;
    }

    /// <summary>
    /// Finds the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Find<TId, TEntity, TDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapGet("/{id}", async ([FromServices] ISender sender, TId id) =>
        {
            return (await sender.Send(new FindEntityCommand<TId, TEntity, TDto>(id))).ToErrorOrOk();
        })
            .Produces<TDto>(200)
            .Produces<Error>(400)
            .Produces<Error>(401)
            .Produces<Error>(403)
            .Produces<Error>(404)
            .Produces<Error>(422).MapToApiVersion(version);

        return builder;
    }

    /// <summary>
    /// Creates the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <typeparam name="TCreateDto">The create dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Create<TId, TEntity, TDto, TCreateDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        builder
            .MapPost("/", async (HttpContext httpContext, [FromServices] ISender sender, [FromBody] TCreateDto dto) =>
            {
                return (await sender.Send(new CreateEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrCreated($"{httpContext.Request.Path}/api/{typeof(TEntity).Name}");
            })
            .Accepts<TCreateDto>("application/json")
            .Produces<TDto>(201)
            .Produces<Error>(400)
            .Produces<Error>(401)
            .Produces<Error>(403)
            .Produces<Error>(404)
            .Produces<Error>(422).MapToApiVersion(version);
        return builder;
    }

    /// <summary>
    /// Modifies the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Modify<TId, TEntity, TDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapPut("/{id}", async ([FromServices] ISender sender, TId id, [FromBody] TDto dto) =>
        {
            return (await sender.Send(new ModifyEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrOk();
        })
            .Accepts<TDto>("application/json")
            .Produces<TDto>(200)
            .Produces<Error>(400)
            .Produces<Error>(401)
            .Produces<Error>(403)
            .Produces<Error>(404)
            .Produces<Error>(422).MapToApiVersion(version);

        return builder;
    }

    /// <summary>
    /// Upserts the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Upsert<TId, TEntity, TDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapPatch("/", async ([FromServices] ISender sender, [FromBody] TDto dto) =>
        {
            return (await sender.Send(new UpsertEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrOk();
        })
        .Accepts<TDto>("application/json")
        .Produces<TDto>(200)
        .Produces<Error>(400)
        .Produces<Error>(401)
        .Produces<Error>(403)
        .Produces<Error>(404)
        .Produces<Error>(422).MapToApiVersion(version);

        return builder;
    }

    /// <summary>
    /// Upserts the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder UpsertMany<TId, TEntity, TDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapPatch("/many", async ([FromServices] ISender sender, TId id, [FromBody] IEnumerable<TDto> dtos) =>
        {
            return (await sender.Send(new UpsertManyEntityCommand<TId, TEntity, TDto>(dtos))).ToErrorOrOk();
        })
            .Accepts<IEnumerable<TDto>>("application/json")
            .Produces<IEnumerable<TDto>>(200)
            .Produces<Error>(400)
            .Produces<Error>(401)
            .Produces<Error>(403)
            .Produces<Error>(404)
            .Produces<Error>(422).MapToApiVersion(version);

        return builder;
    }

    /// <summary>
    /// Deletes the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Delete<TId, TEntity, TDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapDelete("/", async ([FromServices] ISender sender, TId id) =>
        {
            return (await sender.Send(new DeleteEntityCommand<TId, TEntity, TDto>(id))).ToErrorOrOk();
        })
            .Produces<TDto>(200)
            .Produces<Error>(400)
            .Produces<Error>(401)
            .Produces<Error>(403)
            .Produces<Error>(404)
            .Produces<Error>(422).MapToApiVersion(version);

        return builder;
    }

    /// <summary>
    /// Deletes the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <param name="version">The version</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder DeleteMany<TId, TEntity, TDto>(this RouteGroupBuilder builder, int version)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapDelete("/many", async ([FromServices] ISender sender, [FromBody] IEnumerable<TId> ids) =>
        {
            return (await sender.Send(new DeleteManyEntityCommand<TId, TEntity, TDto>(ids))).ToErrorOrOk();
        })
            .Produces<Deleted>(200)
            .Produces<Error>(400)
            .Produces<Error>(401)
            .Produces<Error>(403)
            .Produces<Error>(404)
            .Produces<Error>(422).MapToApiVersion(version);

        return builder;
    }
}
