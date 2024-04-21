
using Clean.Application.Commands;
using Clean.Domain.Common;
using Clean.Web.Extensions;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Security.Cryptography;

namespace Clean.Web.Endpoints;

public static class EntityEndpointsExtension
{
    public static IEndpointRouteBuilder MapEntityEndpoints<TId, TEntity, TDto, TCreateDto>(this IEndpointRouteBuilder builder)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        var groupName = typeof(TEntity).Name;
        builder
            .MapGroup($"/api/{groupName}")
            .MapEntityApi<TId, TEntity, TDto, TCreateDto>(groupName)
            .WithTags(groupName)
            .WithOpenApi();

        return builder;
    }

    public static RouteGroupBuilder MapEntityApi<TId, TEntity, TDto, TCreateDto>(this RouteGroupBuilder builder, string groupName)
        where TId : IEquatable<TId>
        where TEntity : BaseEntity<TId, TEntity, TDto>
        where TDto : IEntityDto<TId, TEntity, TDto>
        where TCreateDto : ICreateEntityDto<TId, TEntity, TDto>
    {
        builder.MapGet("/", async ([FromServices] ISender sender) =>
        {
            return await sender.Send(new FindAllEntityCommand<TId, TEntity, TDto>());
        });
        builder.MapGet("/{id}", async ([FromServices] ISender sender, TId id) =>
        {
            return (await sender.Send(new FindEntityCommand<TId, TEntity, TDto>(id))).ToErrorOrOk();
        });
        builder.MapPost("/", async (HttpContext httpContext, [FromServices] ISender sender, [FromBody] TCreateDto dto) =>
        {
            return (await sender.Send(new CreateEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrCreated($"{httpContext.Request.Path}/api/{groupName}");
        });
        builder.MapPut("/{id}", async ([FromServices] ISender sender, TId id, [FromBody] TDto dto) =>
        {
            return (await sender.Send(new ModifyEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrOk();
        });
        builder.MapPatch("/", async ([FromServices] ISender sender, TId id, [FromBody] TDto dto) =>
        {
            return (await sender.Send(new UpsertEntityCommand<TId, TEntity, TDto>(dto))).ToErrorOrOk();
        });
        builder.MapPatch("/many", async ([FromServices] ISender sender, TId id, [FromBody] IEnumerable<TDto> dtos) =>
        {
            return (await sender.Send(new UpsertManyEntityCommand<TId, TEntity, TDto>(dtos))).ToErrorOrOk();
        });
        builder.MapDelete("/{id}", async ([FromServices] ISender sender, TId id) =>
        {
            return (await sender.Send(new DeleteEntityCommand<TId, TEntity, TDto>(id))).ToErrorOrOk();
        });
        builder.MapDelete("/many", async ([FromServices] ISender sender, TId id, [FromBody] IEnumerable<TId> ids) =>
        {
            return (await sender.Send(new DeleteManyEntityCommand<TId, TEntity, TDto>(ids))).ToErrorOrOk();
        });

        return builder;
    }
}
