using Asp.Versioning;
using CleanCore.Web.Extensions;
using ErrorOr;
using JsonNet.ContractResolvers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unchase.Swashbuckle.AspNetCore.Extensions.Extensions;

namespace CleanCore.Web;

/// <summary>
/// The clean application class
/// </summary>
public static class CleanApplication
{
    /// <summary>
    /// Creates the args
    /// </summary>
    /// <param name="args">The args</param>
    /// <param name="services">The services</param>
    /// <param name="apiVersioning">The api versioning</param>
    /// <returns>The web application</returns>
    public static WebApplication Create(
        string[] args,
        Action<IServiceCollection>? services = null,
        Action<ApiVersioningOptions>? apiVersioning = null)
    {
        return Create(args, cleanApplicationOptions: _ => { }, services: services, apiVersioning: apiVersioning);
    }

    /// <summary>
    /// Creates the args
    /// </summary>
    /// <param name="args">The args</param>
    /// <param name="cleanApplicationOptions">The clean application options</param>
    /// <param name="services">The services</param>
    /// <param name="apiVersioning">The api versioning</param>
    /// <returns>The app</returns>
    public static WebApplication Create(
        string[] args,
        Action<CleanApplicationOptions> cleanApplicationOptions,
        Action<IServiceCollection>? services = null,
        Action<ApiVersioningOptions>? apiVersioning = null)
    {

        var caOpts = new CleanApplicationOptions();
        cleanApplicationOptions(caOpts);

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddProblemDetails();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddMvc()
            .AddNewtonsoftJson(options => {
                options.SerializerSettings.Converters.Add(
                    new Newtonsoft.Json.Converters.StringEnumConverter(new LowerCaseNamingStrategy()));
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                options.SerializerSettings.ContractResolver =
                    new PrivateSetterCamelCasePropertyNamesContractResolver
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    };
            })
            .ConfigureApiBehaviorOptions(opt => {
                opt.InvalidModelStateResponseFactory =
                    context => new BadRequestObjectResult(context.ModelState.ToErrorOr());
            });
        builder.Services.AddApiVersioning(
                    options =>
                    {
                        options.ReportApiVersions = true;
                        options.AssumeDefaultVersionWhenUnspecified = true;
                        options.DefaultApiVersion = new ApiVersion(caOpts.DefaultApiVersion);
                        options.ApiVersionReader = new HeaderApiVersionReader("x-api-version");

                        apiVersioning?.Invoke(options);
                    })
                .AddApiExplorer(
                    options =>
                    {
                        options.GroupNameFormat = "'v'VVV";
                        options.SubstituteApiVersionInUrl = true;
                    })
                .EnableApiVersionBinding();
        builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
        builder.Services.AddSwaggerGen(options =>
        {
            options.OperationFilter<SwaggerDefaultValues>();
            options.AddEnumsWithValuesFixFilters();
            options.UseAllOfToExtendReferenceSchemas();
        });
        builder.Services.AddSwaggerGenNewtonsoftSupport();
        builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
        {
            options.SerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.SnakeCaseLower;
        });

        services?.Invoke(builder.Services);

        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI(
            options =>
            {
                var descriptions = app.DescribeApiVersions();

                // build a swagger endpoint for each discovered API version
                foreach (var description in descriptions)
                {
                    var url = $"/swagger/{description.GroupName}/swagger.json";
                    var name = description.GroupName.ToUpperInvariant();
                    options.SwaggerEndpoint(url, name);
                }
            });

        return app;
    }
}

/// <summary>
/// The clean application options class
/// </summary>
public class CleanApplicationOptions
{
    /// <summary>
    /// Gets or sets the value of the default api version
    /// </summary>
    public int DefaultApiVersion { get; set; } = 1;
}
