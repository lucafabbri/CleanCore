using Asp.Versioning;
using CleanCore.Examples.CounterWebApp.Domain;
using CleanCore.Examples.CounterWebApp.Infrastructure;
using CleanCore.Web.Endpoints;
using CleanCore.Web.Extensions;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using Unchase.Swashbuckle.AspNetCore.Extensions.Extensions;
using CleanCore.Web;
using JsonNet.ContractResolvers;
using Microsoft.AspNetCore.Mvc;
using ErrorOr;

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
                options.DefaultApiVersion = new ApiVersion(2);

                options.Policies.Sunset(1)
                                .Effective(DateTimeOffset.Now.AddDays(60));
            })
        .AddApiExplorer(
            options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            })
        .EnableApiVersionBinding();
builder.Services.AddCounters();
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
builder.Services.AddSwaggerGen(options =>
{
    options.OperationFilter<SwaggerDefaultValues>();
    options.AddEnumsWithValuesFixFilters();
});
builder.Services.AddSwaggerGenNewtonsoftSupport();
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.SnakeCaseLower;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
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
}

app.MapEntity<Counter>(versions: [1,2]).All<Counter>(version: 1).All<Counter>(version: 2);

app.Run();
