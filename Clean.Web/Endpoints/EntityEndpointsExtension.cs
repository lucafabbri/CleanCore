
using Clean.Application.Commands;
using Clean.Domain.Common;
using Clean.Web.Extensions;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Clean.Web.Endpoints;

public static class EntityEndpointsExtension
{
    public static RouteGroupBuilder MapEntity<TEntity>(this IEndpointRouteBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.MapEntity<int, TEntity>();
    }
    public static RouteGroupBuilder MapEntity<TId, TEntity>(this IEndpointRouteBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.MapEntity<TId, TEntity, TEntity, TEntity>();
    }

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

    public static RouteGroupBuilder FindAll<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.FindAll<int, TEntity>();
    }

    public static RouteGroupBuilder Find<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Find<int, TEntity>();
    }

    public static RouteGroupBuilder Create<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Create<int, TEntity>();
    }

    public static RouteGroupBuilder Modify<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Modify<int, TEntity>();
    }

    public static RouteGroupBuilder Upsert<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Upsert<int, TEntity>();
    }

    public static RouteGroupBuilder UpsertMany<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.UpsertMany<int, TEntity>();
    }

    public static RouteGroupBuilder Delete<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.Delete<int, TEntity>();
    }

    public static RouteGroupBuilder DeleteMany<TEntity>(this RouteGroupBuilder builder)
        where TEntity : BaseIntEntityAndDto<TEntity>
    {
        return builder.DeleteMany<int, TEntity>();
    }

    public static RouteGroupBuilder FindAll<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.FindAll<TId, TEntity, TEntity>();
    }

    public static RouteGroupBuilder Find<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Find<TId, TEntity, TEntity>();
    }

    public static RouteGroupBuilder Create<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Create<TId, TEntity, TEntity, TEntity>();
    }

    public static RouteGroupBuilder Modify<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Modify<TId, TEntity, TEntity>();
    }

    public static RouteGroupBuilder Upsert<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Upsert<TId, TEntity, TEntity>();
    }

    public static RouteGroupBuilder UpsertMany<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.UpsertMany<TId, TEntity, TEntity>();
    }

    public static RouteGroupBuilder Delete<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.Delete<TId, TEntity, TEntity>();
    }

    public static RouteGroupBuilder DeleteMany<TId, TEntity>(this RouteGroupBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntityAndDto<TId, TEntity>
    {
        return builder.DeleteMany<TId, TEntity, TEntity>();
    }

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
