<a name='assembly'></a>
# CleanCore.Web

## Contents

- [CleanApplication](#T-CleanCore-Web-CleanApplication 'CleanCore.Web.CleanApplication')
  - [Create(args,services,apiVersioning)](#M-CleanCore-Web-CleanApplication-Create-System-String[],System-Action{Microsoft-Extensions-DependencyInjection-IServiceCollection},System-Action{Asp-Versioning-ApiVersioningOptions}- 'CleanCore.Web.CleanApplication.Create(System.String[],System.Action{Microsoft.Extensions.DependencyInjection.IServiceCollection},System.Action{Asp.Versioning.ApiVersioningOptions})')
  - [Create(args,cleanApplicationOptions,services,apiVersioning)](#M-CleanCore-Web-CleanApplication-Create-System-String[],System-Action{CleanCore-Web-CleanApplicationOptions},System-Action{Microsoft-Extensions-DependencyInjection-IServiceCollection},System-Action{Asp-Versioning-ApiVersioningOptions}- 'CleanCore.Web.CleanApplication.Create(System.String[],System.Action{CleanCore.Web.CleanApplicationOptions},System.Action{Microsoft.Extensions.DependencyInjection.IServiceCollection},System.Action{Asp.Versioning.ApiVersioningOptions})')
- [CleanApplicationOptions](#T-CleanCore-Web-CleanApplicationOptions 'CleanCore.Web.CleanApplicationOptions')
  - [DefaultApiVersion](#P-CleanCore-Web-CleanApplicationOptions-DefaultApiVersion 'CleanCore.Web.CleanApplicationOptions.DefaultApiVersion')
- [ConfigureSwaggerOptions](#T-CleanCore-Web-Extensions-ConfigureSwaggerOptions 'CleanCore.Web.Extensions.ConfigureSwaggerOptions')
  - [#ctor(provider,configuration)](#M-CleanCore-Web-Extensions-ConfigureSwaggerOptions-#ctor-Asp-Versioning-ApiExplorer-IApiVersionDescriptionProvider,Microsoft-Extensions-Configuration-IConfiguration- 'CleanCore.Web.Extensions.ConfigureSwaggerOptions.#ctor(Asp.Versioning.ApiExplorer.IApiVersionDescriptionProvider,Microsoft.Extensions.Configuration.IConfiguration)')
  - [configuration](#F-CleanCore-Web-Extensions-ConfigureSwaggerOptions-configuration 'CleanCore.Web.Extensions.ConfigureSwaggerOptions.configuration')
  - [provider](#F-CleanCore-Web-Extensions-ConfigureSwaggerOptions-provider 'CleanCore.Web.Extensions.ConfigureSwaggerOptions.provider')
  - [Configure()](#M-CleanCore-Web-Extensions-ConfigureSwaggerOptions-Configure-Swashbuckle-AspNetCore-SwaggerGen-SwaggerGenOptions- 'CleanCore.Web.Extensions.ConfigureSwaggerOptions.Configure(Swashbuckle.AspNetCore.SwaggerGen.SwaggerGenOptions)')
  - [CreateInfoForApiVersion(description)](#M-CleanCore-Web-Extensions-ConfigureSwaggerOptions-CreateInfoForApiVersion-Asp-Versioning-ApiExplorer-ApiVersionDescription- 'CleanCore.Web.Extensions.ConfigureSwaggerOptions.CreateInfoForApiVersion(Asp.Versioning.ApiExplorer.ApiVersionDescription)')
- [EntityEndpointsExtension](#T-CleanCore-Web-Endpoints-EntityEndpointsExtension 'CleanCore.Web.Endpoints.EntityEndpointsExtension')
  - [All\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.All``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [All\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.All``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [All\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.All``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [All\`\`4(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``4-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.All``4(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Create\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Create``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Create\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Create``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Create\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Create``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Create\`\`4(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``4-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Create``4(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [DeleteMany\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-DeleteMany``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.DeleteMany``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [DeleteMany\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-DeleteMany``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.DeleteMany``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [DeleteMany\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-DeleteMany``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.DeleteMany``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Delete\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Delete``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Delete``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Delete\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Delete``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Delete``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Delete\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Delete``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Delete``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [FindAll\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-FindAll``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.FindAll``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [FindAll\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-FindAll``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.FindAll``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [FindAll\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-FindAll``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.FindAll``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Find\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Find``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Find``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Find\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Find``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Find``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Find\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Find``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Find``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [MapEntity\`\`1(builder,prefix,versions)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``1-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.MapEntity``1(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,System.Int32[])')
  - [MapEntity\`\`2(builder,prefix,versions)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``2-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.MapEntity``2(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,System.Int32[])')
  - [MapEntity\`\`3(builder,prefix,versions)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``3-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.MapEntity``3(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,System.Int32[])')
  - [MapEntity\`\`4(builder,prefix,versions)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``4-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.MapEntity``4(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,System.Int32[])')
  - [Modify\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Modify``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Modify``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Modify\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Modify``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Modify``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Modify\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Modify``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Modify``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [UpsertMany\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-UpsertMany``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.UpsertMany``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [UpsertMany\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-UpsertMany``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.UpsertMany``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [UpsertMany\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-UpsertMany``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.UpsertMany``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Upsert\`\`1(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Upsert``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Upsert``1(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Upsert\`\`2(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Upsert``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Upsert``2(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
  - [Upsert\`\`3(builder,version)](#M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Upsert``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32- 'CleanCore.Web.Endpoints.EntityEndpointsExtension.Upsert``3(Microsoft.AspNetCore.Routing.RouteGroupBuilder,System.Int32)')
- [LowerCaseNamingStrategy](#T-CleanCore-Web-LowerCaseNamingStrategy 'CleanCore.Web.LowerCaseNamingStrategy')
  - [#ctor(processDictionaryKeys,overrideSpecifiedNames)](#M-CleanCore-Web-LowerCaseNamingStrategy-#ctor-System-Boolean,System-Boolean- 'CleanCore.Web.LowerCaseNamingStrategy.#ctor(System.Boolean,System.Boolean)')
  - [#ctor(processDictionaryKeys,overrideSpecifiedNames,processExtensionDataNames)](#M-CleanCore-Web-LowerCaseNamingStrategy-#ctor-System-Boolean,System-Boolean,System-Boolean- 'CleanCore.Web.LowerCaseNamingStrategy.#ctor(System.Boolean,System.Boolean,System.Boolean)')
  - [#ctor()](#M-CleanCore-Web-LowerCaseNamingStrategy-#ctor 'CleanCore.Web.LowerCaseNamingStrategy.#ctor')
  - [ResolvePropertyName(name)](#M-CleanCore-Web-LowerCaseNamingStrategy-ResolvePropertyName-System-String- 'CleanCore.Web.LowerCaseNamingStrategy.ResolvePropertyName(System.String)')
- [ResultsExtension](#T-CleanCore-Web-Extensions-ResultsExtension 'CleanCore.Web.Extensions.ResultsExtension')
  - [ToErrorOrAccepted\`\`1(result)](#M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrAccepted``1-ErrorOr-ErrorOr{``0}- 'CleanCore.Web.Extensions.ResultsExtension.ToErrorOrAccepted``1(ErrorOr.ErrorOr{``0})')
  - [ToErrorOrCreated\`\`1(result,uri)](#M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrCreated``1-ErrorOr-ErrorOr{``0},System-String- 'CleanCore.Web.Extensions.ResultsExtension.ToErrorOrCreated``1(ErrorOr.ErrorOr{``0},System.String)')
  - [ToErrorOrNoContent(result)](#M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrNoContent-ErrorOr-ErrorOr{System-Object}- 'CleanCore.Web.Extensions.ResultsExtension.ToErrorOrNoContent(ErrorOr.ErrorOr{System.Object})')
  - [ToErrorOrOk\`\`1(result)](#M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrOk``1-ErrorOr-ErrorOr{``0}- 'CleanCore.Web.Extensions.ResultsExtension.ToErrorOrOk``1(ErrorOr.ErrorOr{``0})')
- [SwaggerDefaultValues](#T-CleanCore-Web-Extensions-SwaggerDefaultValues 'CleanCore.Web.Extensions.SwaggerDefaultValues')
  - [Apply()](#M-CleanCore-Web-Extensions-SwaggerDefaultValues-Apply-Microsoft-OpenApi-Models-OpenApiOperation,Swashbuckle-AspNetCore-SwaggerGen-OperationFilterContext- 'CleanCore.Web.Extensions.SwaggerDefaultValues.Apply(Microsoft.OpenApi.Models.OpenApiOperation,Swashbuckle.AspNetCore.SwaggerGen.OperationFilterContext)')

<a name='T-CleanCore-Web-CleanApplication'></a>
## CleanApplication `type`

##### Namespace

CleanCore.Web

##### Summary

The clean application class

<a name='M-CleanCore-Web-CleanApplication-Create-System-String[],System-Action{Microsoft-Extensions-DependencyInjection-IServiceCollection},System-Action{Asp-Versioning-ApiVersioningOptions}-'></a>
### Create(args,services,apiVersioning) `method`

##### Summary

Creates the args

##### Returns

The web application

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The args |
| services | [System.Action{Microsoft.Extensions.DependencyInjection.IServiceCollection}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.Extensions.DependencyInjection.IServiceCollection}') | The services |
| apiVersioning | [System.Action{Asp.Versioning.ApiVersioningOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Asp.Versioning.ApiVersioningOptions}') | The api versioning |

<a name='M-CleanCore-Web-CleanApplication-Create-System-String[],System-Action{CleanCore-Web-CleanApplicationOptions},System-Action{Microsoft-Extensions-DependencyInjection-IServiceCollection},System-Action{Asp-Versioning-ApiVersioningOptions}-'></a>
### Create(args,cleanApplicationOptions,services,apiVersioning) `method`

##### Summary

Creates the args

##### Returns

The app

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The args |
| cleanApplicationOptions | [System.Action{CleanCore.Web.CleanApplicationOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{CleanCore.Web.CleanApplicationOptions}') | The clean application options |
| services | [System.Action{Microsoft.Extensions.DependencyInjection.IServiceCollection}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Microsoft.Extensions.DependencyInjection.IServiceCollection}') | The services |
| apiVersioning | [System.Action{Asp.Versioning.ApiVersioningOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Asp.Versioning.ApiVersioningOptions}') | The api versioning |

<a name='T-CleanCore-Web-CleanApplicationOptions'></a>
## CleanApplicationOptions `type`

##### Namespace

CleanCore.Web

##### Summary

The clean application options class

<a name='P-CleanCore-Web-CleanApplicationOptions-DefaultApiVersion'></a>
### DefaultApiVersion `property`

##### Summary

Gets or sets the value of the default api version

<a name='T-CleanCore-Web-Extensions-ConfigureSwaggerOptions'></a>
## ConfigureSwaggerOptions `type`

##### Namespace

CleanCore.Web.Extensions

##### Summary

Configures the Swagger generation options.

##### Remarks

This allows API versioning to define a Swagger document per API version after the
[IApiVersionDescriptionProvider](#T-Asp-Versioning-ApiExplorer-IApiVersionDescriptionProvider 'Asp.Versioning.ApiExplorer.IApiVersionDescriptionProvider') service has been resolved from the service container.

<a name='M-CleanCore-Web-Extensions-ConfigureSwaggerOptions-#ctor-Asp-Versioning-ApiExplorer-IApiVersionDescriptionProvider,Microsoft-Extensions-Configuration-IConfiguration-'></a>
### #ctor(provider,configuration) `constructor`

##### Summary

Initializes a new instance of the [ConfigureSwaggerOptions](#T-CleanCore-Web-Extensions-ConfigureSwaggerOptions 'CleanCore.Web.Extensions.ConfigureSwaggerOptions') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| provider | [Asp.Versioning.ApiExplorer.IApiVersionDescriptionProvider](#T-Asp-Versioning-ApiExplorer-IApiVersionDescriptionProvider 'Asp.Versioning.ApiExplorer.IApiVersionDescriptionProvider') | The [IApiVersionDescriptionProvider](#T-Asp-Versioning-ApiExplorer-IApiVersionDescriptionProvider 'Asp.Versioning.ApiExplorer.IApiVersionDescriptionProvider') used to generate Swagger documents. |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |

<a name='F-CleanCore-Web-Extensions-ConfigureSwaggerOptions-configuration'></a>
### configuration `constants`

##### Summary

The configuration

<a name='F-CleanCore-Web-Extensions-ConfigureSwaggerOptions-provider'></a>
### provider `constants`

##### Summary

The provider

<a name='M-CleanCore-Web-Extensions-ConfigureSwaggerOptions-Configure-Swashbuckle-AspNetCore-SwaggerGen-SwaggerGenOptions-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-CleanCore-Web-Extensions-ConfigureSwaggerOptions-CreateInfoForApiVersion-Asp-Versioning-ApiExplorer-ApiVersionDescription-'></a>
### CreateInfoForApiVersion(description) `method`

##### Summary

Creates the info for api version using the specified description

##### Returns

The info

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [Asp.Versioning.ApiExplorer.ApiVersionDescription](#T-Asp-Versioning-ApiExplorer-ApiVersionDescription 'Asp.Versioning.ApiExplorer.ApiVersionDescription') | The description |

<a name='T-CleanCore-Web-Endpoints-EntityEndpointsExtension'></a>
## EntityEndpointsExtension `type`

##### Namespace

CleanCore.Web.Endpoints

##### Summary

The entity endpoints extension class

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### All\`\`1(builder,version) `method`

##### Summary

Alls the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### All\`\`2(builder,version) `method`

##### Summary

Alls the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### All\`\`3(builder,version) `method`

##### Summary

Alls the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-All``4-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### All\`\`4(builder,version) `method`

##### Summary

Alls the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |
| TCreateDto | The create dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Create\`\`1(builder,version) `method`

##### Summary

Creates the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Create\`\`2(builder,version) `method`

##### Summary

Creates the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Create\`\`3(builder,version) `method`

##### Summary

Creates the builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Create``4-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Create\`\`4(builder,version) `method`

##### Summary

Creates the builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |
| TCreateDto | The create dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-DeleteMany``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### DeleteMany\`\`1(builder,version) `method`

##### Summary

Deletes the many using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-DeleteMany``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### DeleteMany\`\`2(builder,version) `method`

##### Summary

Deletes the many using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-DeleteMany``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### DeleteMany\`\`3(builder,version) `method`

##### Summary

Deletes the many using the specified builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Delete``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Delete\`\`1(builder,version) `method`

##### Summary

Deletes the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Delete``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Delete\`\`2(builder,version) `method`

##### Summary

Deletes the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Delete``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Delete\`\`3(builder,version) `method`

##### Summary

Deletes the builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-FindAll``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### FindAll\`\`1(builder,version) `method`

##### Summary

Finds the all using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-FindAll``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### FindAll\`\`2(builder,version) `method`

##### Summary

Finds the all using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-FindAll``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### FindAll\`\`3(builder,version) `method`

##### Summary

Finds the all using the specified builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Find``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Find\`\`1(builder,version) `method`

##### Summary

Finds the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Find``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Find\`\`2(builder,version) `method`

##### Summary

Finds the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Find``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Find\`\`3(builder,version) `method`

##### Summary

Finds the builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``1-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]-'></a>
### MapEntity\`\`1(builder,prefix,versions) `method`

##### Summary

Maps the entity using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.IEndpointRouteBuilder](#T-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder 'Microsoft.AspNetCore.Routing.IEndpointRouteBuilder') | The builder |
| prefix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the prefix |
| versions | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The versions |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``2-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]-'></a>
### MapEntity\`\`2(builder,prefix,versions) `method`

##### Summary

Maps the entity using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.IEndpointRouteBuilder](#T-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder 'Microsoft.AspNetCore.Routing.IEndpointRouteBuilder') | The builder |
| prefix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the prefix |
| versions | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The versions |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``3-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]-'></a>
### MapEntity\`\`3(builder,prefix,versions) `method`

##### Summary

Maps the entity using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.IEndpointRouteBuilder](#T-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder 'Microsoft.AspNetCore.Routing.IEndpointRouteBuilder') | The builder |
| prefix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the prefix |
| versions | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The versions |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-MapEntity``4-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder,System-String,System-Int32[]-'></a>
### MapEntity\`\`4(builder,prefix,versions) `method`

##### Summary

Maps the entity using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.IEndpointRouteBuilder](#T-Microsoft-AspNetCore-Routing-IEndpointRouteBuilder 'Microsoft.AspNetCore.Routing.IEndpointRouteBuilder') | The builder |
| prefix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the prefix |
| versions | [System.Int32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32[] 'System.Int32[]') | The versions |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |
| TCreateDto | The create dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Modify``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Modify\`\`1(builder,version) `method`

##### Summary

Modifies the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Modify``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Modify\`\`2(builder,version) `method`

##### Summary

Modifies the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Modify``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Modify\`\`3(builder,version) `method`

##### Summary

Modifies the builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-UpsertMany``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### UpsertMany\`\`1(builder,version) `method`

##### Summary

Upserts the many using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-UpsertMany``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### UpsertMany\`\`2(builder,version) `method`

##### Summary

Upserts the many using the specified builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-UpsertMany``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### UpsertMany\`\`3(builder,version) `method`

##### Summary

Upserts the many using the specified builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Upsert``1-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Upsert\`\`1(builder,version) `method`

##### Summary

Upserts the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Upsert``2-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Upsert\`\`2(builder,version) `method`

##### Summary

Upserts the builder

##### Returns

The route group builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |

<a name='M-CleanCore-Web-Endpoints-EntityEndpointsExtension-Upsert``3-Microsoft-AspNetCore-Routing-RouteGroupBuilder,System-Int32-'></a>
### Upsert\`\`3(builder,version) `method`

##### Summary

Upserts the builder

##### Returns

The builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| builder | [Microsoft.AspNetCore.Routing.RouteGroupBuilder](#T-Microsoft-AspNetCore-Routing-RouteGroupBuilder 'Microsoft.AspNetCore.Routing.RouteGroupBuilder') | The builder |
| version | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The version |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TId | The id |
| TEntity | The entity |
| TDto | The dto |

<a name='T-CleanCore-Web-LowerCaseNamingStrategy'></a>
## LowerCaseNamingStrategy `type`

##### Namespace

CleanCore.Web

##### Summary

The lower case naming strategy class

##### See Also

- [Newtonsoft.Json.Serialization.NamingStrategy](#T-Newtonsoft-Json-Serialization-NamingStrategy 'Newtonsoft.Json.Serialization.NamingStrategy')

<a name='M-CleanCore-Web-LowerCaseNamingStrategy-#ctor-System-Boolean,System-Boolean-'></a>
### #ctor(processDictionaryKeys,overrideSpecifiedNames) `constructor`

##### Summary

Initializes a new instance of the [LowerCaseNamingStrategy](#T-CleanCore-Web-LowerCaseNamingStrategy 'CleanCore.Web.LowerCaseNamingStrategy') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| processDictionaryKeys | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [process dictionary keys]. |
| overrideSpecifiedNames | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [override specified names]. |

<a name='M-CleanCore-Web-LowerCaseNamingStrategy-#ctor-System-Boolean,System-Boolean,System-Boolean-'></a>
### #ctor(processDictionaryKeys,overrideSpecifiedNames,processExtensionDataNames) `constructor`

##### Summary

Initializes a new instance of the [LowerCaseNamingStrategy](#T-CleanCore-Web-LowerCaseNamingStrategy 'CleanCore.Web.LowerCaseNamingStrategy') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| processDictionaryKeys | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [process dictionary keys]. |
| overrideSpecifiedNames | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [override specified names]. |
| processExtensionDataNames | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [process extension data names]. |

<a name='M-CleanCore-Web-LowerCaseNamingStrategy-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [LowerCaseNamingStrategy](#T-CleanCore-Web-LowerCaseNamingStrategy 'CleanCore.Web.LowerCaseNamingStrategy') class.

##### Parameters

This constructor has no parameters.

<a name='M-CleanCore-Web-LowerCaseNamingStrategy-ResolvePropertyName-System-String-'></a>
### ResolvePropertyName(name) `method`

##### Summary

Resolves the specified property name.

##### Returns

The resolved property name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name to resolve. |

<a name='T-CleanCore-Web-Extensions-ResultsExtension'></a>
## ResultsExtension `type`

##### Namespace

CleanCore.Web.Extensions

##### Summary

The results extension class

<a name='M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrAccepted``1-ErrorOr-ErrorOr{``0}-'></a>
### ToErrorOrAccepted\`\`1(result) `method`

##### Summary

Returns the error or accepted using the specified result

##### Returns

The response

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [ErrorOr.ErrorOr{\`\`0}](#T-ErrorOr-ErrorOr{``0} 'ErrorOr.ErrorOr{``0}') | The result |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | The value |

<a name='M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrCreated``1-ErrorOr-ErrorOr{``0},System-String-'></a>
### ToErrorOrCreated\`\`1(result,uri) `method`

##### Summary

Returns the error or created using the specified result

##### Returns

The response

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [ErrorOr.ErrorOr{\`\`0}](#T-ErrorOr-ErrorOr{``0} 'ErrorOr.ErrorOr{``0}') | The result |
| uri | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The uri |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | The value |

<a name='M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrNoContent-ErrorOr-ErrorOr{System-Object}-'></a>
### ToErrorOrNoContent(result) `method`

##### Summary

Returns the error or no content using the specified result

##### Returns

The response

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [ErrorOr.ErrorOr{System.Object}](#T-ErrorOr-ErrorOr{System-Object} 'ErrorOr.ErrorOr{System.Object}') | The result |

<a name='M-CleanCore-Web-Extensions-ResultsExtension-ToErrorOrOk``1-ErrorOr-ErrorOr{``0}-'></a>
### ToErrorOrOk\`\`1(result) `method`

##### Summary

Returns the error or ok using the specified result

##### Returns

The response

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [ErrorOr.ErrorOr{\`\`0}](#T-ErrorOr-ErrorOr{``0} 'ErrorOr.ErrorOr{``0}') | The result |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | The value |

<a name='T-CleanCore-Web-Extensions-SwaggerDefaultValues'></a>
## SwaggerDefaultValues `type`

##### Namespace

CleanCore.Web.Extensions

##### Summary

Represents the OpenAPI/Swashbuckle operation filter used to document information provided, but not used.

##### Remarks

This [IOperationFilter](#T-Swashbuckle-AspNetCore-SwaggerGen-IOperationFilter 'Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter') is only required due to bugs in the [SwaggerGenerator](#T-Swashbuckle-AspNetCore-SwaggerGen-SwaggerGenerator 'Swashbuckle.AspNetCore.SwaggerGen.SwaggerGenerator').
Once they are fixed and published, this class can be removed.

<a name='M-CleanCore-Web-Extensions-SwaggerDefaultValues-Apply-Microsoft-OpenApi-Models-OpenApiOperation,Swashbuckle-AspNetCore-SwaggerGen-OperationFilterContext-'></a>
### Apply() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
