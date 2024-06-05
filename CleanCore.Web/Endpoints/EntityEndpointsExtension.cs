
using CleanCore.Application.Commands;
using CleanCore.Domain.Common;
using CleanCore.Web.Extensions;
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
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder MapEntity<TEntity>(this IEndpointRouteBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.MapEntity<int, TEntity>();
    }
    /// <summary>
    /// Maps the entity using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder MapEntity<TId, TEntity>(this IEndpointRouteBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.MapEntity<TId, TEntity, TEntity, TEntity>();
    }

    /// <summary>
    /// Maps the entity using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <typeparam name="TCreateDto">The create dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder MapEntity<TId, TEntity, TDto, TCreateDto>(this IEndpointRouteBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        var groupName = typeof(TEntity).Name;
        return builder
            .MapGroup($"/api/{groupName}")
            .WithTags(groupName)
            .WithOpenApi();
    }

    /// <summary>
    /// Alls the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder All<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder
            .FindAll<TEntity>()
            .Find<TEntity>()
            .Create<TEntity>()
            .Modify<TEntity>()
            .Upsert<TEntity>()
            .UpsertMany<TEntity>()
            .Delete<TEntity>()
            .DeleteMany<TEntity>();
    }

    /// <summary>
    /// Alls the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder All<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder
            .FindAll<TId, TEntity>()
            .Find<TId, TEntity>()
            .Create<TId, TEntity>()
            .Modify<TId, TEntity>()
            .Upsert<TId, TEntity>()
            .UpsertMany<TId, TEntity>()
            .Delete<TId, TEntity>()
            .DeleteMany<TId, TEntity>();
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
    public static RouteGroupBuilder All<TId, TEntity, TDto, TCreateDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        return builder
            .FindAll<TId, TEntity, TDto>()
            .Find<TId, TEntity, TDto>()
            .Create<TId, TEntity, TDto, TCreateDto>()
            .Modify<TId, TEntity, TDto>()
            .Upsert<TId, TEntity, TDto>()
            .UpsertMany<TId, TEntity, TDto>()
            .Delete<TId, TEntity, TDto>()
            .DeleteMany<TId, TEntity, TDto>();
    }

    /// <summary>
    /// Finds the all using the specified builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder FindAll<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.FindAll<int, TEntity>();
    }

    /// <summary>
    /// Finds the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Find<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Find<int, TEntity>();
    }

    /// <summary>
    /// Creates the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Create<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Create<int, TEntity>();
    }

    /// <summary>
    /// Modifies the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Modify<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Modify<int, TEntity>();
    }

    /// <summary>
    /// Upserts the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Upsert<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Upsert<int, TEntity>();
    }

    /// <summary>
    /// Upserts the many using the specified builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder UpsertMany<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.UpsertMany<int, TEntity>();
    }

    /// <summary>
    /// Deletes the builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Delete<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Delete<int, TEntity>();
    }

    /// <summary>
    /// Deletes the many using the specified builder
    /// </summary>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder DeleteMany<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.DeleteMany<int, TEntity>();
    }

    /// <summary>
    /// Finds the all using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder FindAll<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.FindAll<TId, TEntity, TEntity>();
    }

    /// <summary>
    /// Finds the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Find<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Find<TId, TEntity, TEntity>();
    }

    /// <summary>
    /// Creates the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Create<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Create<TId, TEntity, TEntity, TEntity>();
    }

    /// <summary>
    /// Modifies the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Modify<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Modify<TId, TEntity, TEntity>();
    }

    /// <summary>
    /// Upserts the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Upsert<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Upsert<TId, TEntity, TEntity>();
    }

    /// <summary>
    /// Upserts the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder UpsertMany<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.UpsertMany<TId, TEntity, TEntity>();
    }

    /// <summary>
    /// Deletes the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder Delete<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Delete<TId, TEntity, TEntity>();
    }

    /// <summary>
    /// Deletes the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The route group builder</returns>
    public static RouteGroupBuilder DeleteMany<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.DeleteMany<TId, TEntity, TEntity>();
    }

    /// <summary>
    /// Finds the all using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder FindAll<TId, TEntity, TDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapGet("/", async ([FromServices] ISender sender) =>
        {
            return await sender.Send(new FindAllEntityCommand<TId, TEntity, TDto>());
        });

        return builder;
    }

    /// <summary>
    /// Finds the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Find<TId, TEntity, TDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapGet("/{id}", async ([FromServices] ISender sender, TId id) =>
        {
            return (await sender.Send(new FindEntityCommand<TId, TEntity, TDto>(id))).ToErrorOrOk();
        });

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
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Create<TId, TEntity, TDto, TCreateDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        builder.MapPost("/", async (HttpContext httpContext, [FromServices] ISender sender, [FromBody] TCreateDto dto) =>
        {
            return (await sender.Send(new CreateEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrCreated($"{httpContext.Request.Path}/api/{typeof(TEntity).Name}");
        });
        return builder;
    }

    /// <summary>
    /// Modifies the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Modify<TId, TEntity, TDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapPut("/{id}", async ([FromServices] ISender sender, TId id, [FromBody] TDto dto) =>
        {
            return (await sender.Send(new ModifyEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrOk();
        });

        return builder;
    }

    /// <summary>
    /// Upserts the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Upsert<TId, TEntity, TDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapPatch("/", async ([FromServices] ISender sender, [FromBody] TDto dto) =>
        {
            return (await sender.Send(new UpsertEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrOk();
        });

        return builder;
    }

    /// <summary>
    /// Upserts the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder UpsertMany<TId, TEntity, TDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapPatch("/many", async ([FromServices] ISender sender, TId id, [FromBody] IEnumerable<TDto> dtos) =>
        {
            return (await sender.Send(new UpsertManyEntityCommand<TId, TEntity, TDto>(dtos))).ToErrorOrOk();
        });

        return builder;
    }

    /// <summary>
    /// Deletes the builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder Delete<TId, TEntity, TDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapDelete("/", async ([FromServices] ISender sender, TId id) =>
        {
            return (await sender.Send(new DeleteEntityCommand<TId, TEntity, TDto>(id))).ToErrorOrOk();
        });

        return builder;
    }

    /// <summary>
    /// Deletes the many using the specified builder
    /// </summary>
    /// <typeparam name="TId">The id</typeparam>
    /// <typeparam name="TEntity">The entity</typeparam>
    /// <typeparam name="TDto">The dto</typeparam>
    /// <param name="builder">The builder</param>
    /// <returns>The builder</returns>
    public static RouteGroupBuilder DeleteMany<TId, TEntity, TDto>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
    {
        builder.MapDelete("/many", async ([FromServices] ISender sender, [FromBody] IEnumerable<TId> ids) =>
        {
            return (await sender.Send(new DeleteManyEntityCommand<TId, TEntity, TDto>(ids))).ToErrorOrOk();
        });

        return builder;
    }
}
