<a name='assembly'></a>
# CleanCore.Application

## Contents

- [BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [configuration](#F-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-configuration 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.configuration')
  - [userProvider](#F-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-userProvider 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.userProvider')
  - [Index](#P-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-Index 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.Index')
  - [DeleteAsync(id)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-DeleteAsync-`0- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.DeleteAsync(`0)')
  - [DeleteManyAsync(ids)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-DeleteManyAsync-System-Collections-Generic-IEnumerable{`0}- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.DeleteManyAsync(System.Collections.Generic.IEnumerable{`0})')
  - [GetAsync(id)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-GetAsync-`0- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.GetAsync(`0)')
  - [GetElasticClient()](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-GetElasticClient 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.GetElasticClient')
  - [IndexAsync(entity)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-IndexAsync-`1- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.IndexAsync(`1)')
  - [IndexManyAsync(entities)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-IndexManyAsync-System-Collections-Generic-IEnumerable{`1}- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.IndexManyAsync(System.Collections.Generic.IEnumerable{`1})')
  - [SearchAsync(query,from,size)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-SearchAsync-Elastic-Clients-Elasticsearch-QueryDsl-Query,System-Int32,System-Int32- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.SearchAsync(Elastic.Clients.Elasticsearch.QueryDsl.Query,System.Int32,System.Int32)')
  - [UpdateAsync(entity)](#M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-UpdateAsync-`1- 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3.UpdateAsync(`1)')
- [CreateElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-CreateElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.CreateElasticEntityCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-CreateElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.CreateElasticEntityCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-CreateElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-CreateEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.CreateElasticEntityCommandHandler`3.Handle(CleanCore.Application.Commands.CreateEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [CreateEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-CreateEntityCommandHandler`3 'CleanCore.Application.Handlers.CreateEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-CreateEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.CreateEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-CreateEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.CreateEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-CreateEntityCommandHandler`3-Handle-CleanCore-Application-Commands-CreateEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.CreateEntityCommandHandler`3.Handle(CleanCore.Application.Commands.CreateEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [CreateEntityCommand\`3](#T-CleanCore-Application-Commands-CreateEntityCommand`3 'CleanCore.Application.Commands.CreateEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-CreateEntityCommand`3-#ctor-CleanCore-Domain-Common-ICreateEntityDto{`0,`1,`2}- 'CleanCore.Application.Commands.CreateEntityCommand`3.#ctor(CleanCore.Domain.Common.ICreateEntityDto{`0,`1,`2})')
- [DeleteElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteElasticEntityCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-DeleteElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.DeleteElasticEntityCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-DeleteElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.DeleteElasticEntityCommandHandler`3.Handle(CleanCore.Application.Commands.DeleteEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [DeleteEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.DeleteEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.DeleteEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.DeleteEntityCommandHandler`3.Handle(CleanCore.Application.Commands.DeleteEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [DeleteEntityCommand\`3](#T-CleanCore-Application-Commands-DeleteEntityCommand`3 'CleanCore.Application.Commands.DeleteEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-DeleteEntityCommand`3-#ctor-`0- 'CleanCore.Application.Commands.DeleteEntityCommand`3.#ctor(`0)')
- [DeleteManyElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteManyElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteManyElasticEntityCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-DeleteManyElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.DeleteManyElasticEntityCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-DeleteManyElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.DeleteManyElasticEntityCommandHandler`3.Handle(CleanCore.Application.Commands.DeleteManyEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [DeleteManyEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteManyEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.DeleteManyEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.DeleteManyEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.DeleteManyEntityCommandHandler`3.Handle(CleanCore.Application.Commands.DeleteManyEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [DeleteManyEntityCommand\`3](#T-CleanCore-Application-Commands-DeleteManyEntityCommand`3 'CleanCore.Application.Commands.DeleteManyEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-DeleteManyEntityCommand`3-#ctor-System-Collections-Generic-IEnumerable{`0}- 'CleanCore.Application.Commands.DeleteManyEntityCommand`3.#ctor(System.Collections.Generic.IEnumerable{`0})')
- [FindAllEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3 'CleanCore.Application.Handlers.FindAllEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.FindAllEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.FindAllEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3-Handle-CleanCore-Application-Commands-FindAllEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.FindAllEntityCommandHandler`3.Handle(CleanCore.Application.Commands.FindAllEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [FindAllEntityCommand\`3](#T-CleanCore-Application-Commands-FindAllEntityCommand`3 'CleanCore.Application.Commands.FindAllEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-FindAllEntityCommand`3-#ctor 'CleanCore.Application.Commands.FindAllEntityCommand`3.#ctor')
- [FindElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-FindElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.FindElasticEntityCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-FindElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.FindElasticEntityCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-FindElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-FindEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.FindElasticEntityCommandHandler`3.Handle(CleanCore.Application.Commands.FindEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [FindEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-FindEntityCommandHandler`3 'CleanCore.Application.Handlers.FindEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-FindEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.FindEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-FindEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.FindEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-FindEntityCommandHandler`3-Handle-CleanCore-Application-Commands-FindEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.FindEntityCommandHandler`3.Handle(CleanCore.Application.Commands.FindEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [FindEntityCommand\`3](#T-CleanCore-Application-Commands-FindEntityCommand`3 'CleanCore.Application.Commands.FindEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-FindEntityCommand`3-#ctor-`0- 'CleanCore.Application.Commands.FindEntityCommand`3.#ctor(`0)')
- [IOrganizationProvider\`1](#T-CleanCore-Application-Services-IOrganizationProvider`1 'CleanCore.Application.Services.IOrganizationProvider`1')
  - [GetOrganization()](#M-CleanCore-Application-Services-IOrganizationProvider`1-GetOrganization 'CleanCore.Application.Services.IOrganizationProvider`1.GetOrganization')
- [IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider')
  - [GetCurrentUser()](#M-CleanCore-Application-Services-IUserProvider-GetCurrentUser 'CleanCore.Application.Services.IUserProvider.GetCurrentUser')
- [ModifyElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-ModifyElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.ModifyElasticEntityCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-ModifyElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.ModifyElasticEntityCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-ModifyElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-ModifyEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.ModifyElasticEntityCommandHandler`3.Handle(CleanCore.Application.Commands.ModifyEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [ModifyEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3 'CleanCore.Application.Handlers.ModifyEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.ModifyEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.ModifyEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3-Handle-CleanCore-Application-Commands-ModifyEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.ModifyEntityCommandHandler`3.Handle(CleanCore.Application.Commands.ModifyEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [ModifyEntityCommand\`3](#T-CleanCore-Application-Commands-ModifyEntityCommand`3 'CleanCore.Application.Commands.ModifyEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-ModifyEntityCommand`3-#ctor-`2- 'CleanCore.Application.Commands.ModifyEntityCommand`3.#ctor(`2)')
- [UpsertElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertElasticEntityCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-UpsertElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.UpsertElasticEntityCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-UpsertElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.UpsertElasticEntityCommandHandler`3.Handle(CleanCore.Application.Commands.UpsertEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [UpsertEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.UpsertEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.UpsertEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.UpsertEntityCommandHandler`3.Handle(CleanCore.Application.Commands.UpsertEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [UpsertEntityCommand\`3](#T-CleanCore-Application-Commands-UpsertEntityCommand`3 'CleanCore.Application.Commands.UpsertEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-UpsertEntityCommand`3-#ctor-`2- 'CleanCore.Application.Commands.UpsertEntityCommand`3.#ctor(`2)')
- [UpsertManyElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertManyElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertManyElasticEntityCommandHandler`3')
  - [#ctor(configuration,userProvider)](#M-CleanCore-Application-Handlers-UpsertManyElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider- 'CleanCore.Application.Handlers.UpsertManyElasticEntityCommandHandler`3.#ctor(Microsoft.Extensions.Configuration.IConfiguration,CleanCore.Application.Services.IUserProvider)')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-UpsertManyElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.UpsertManyElasticEntityCommandHandler`3.Handle(CleanCore.Application.Commands.UpsertManyEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [UpsertManyEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertManyEntityCommandHandler`3')
  - [#ctor(context)](#M-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Application.Handlers.UpsertManyEntityCommandHandler`3.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [_context](#F-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3-_context 'CleanCore.Application.Handlers.UpsertManyEntityCommandHandler`3._context')
  - [Handle(request,cancellationToken)](#M-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken- 'CleanCore.Application.Handlers.UpsertManyEntityCommandHandler`3.Handle(CleanCore.Application.Commands.UpsertManyEntityCommand{`0,`1,`2},System.Threading.CancellationToken)')
- [UpsertManyEntityCommand\`3](#T-CleanCore-Application-Commands-UpsertManyEntityCommand`3 'CleanCore.Application.Commands.UpsertManyEntityCommand`3')
  - [#ctor()](#M-CleanCore-Application-Commands-UpsertManyEntityCommand`3-#ctor-System-Collections-Generic-IEnumerable{`2}- 'CleanCore.Application.Commands.UpsertManyEntityCommand`3.#ctor(System.Collections.Generic.IEnumerable{`2})')

<a name='T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3'></a>
## BaseElasticCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The base elastic command handler class

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='F-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-configuration'></a>
### configuration `constants`

##### Summary

The configuration

<a name='F-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-userProvider'></a>
### userProvider `constants`

##### Summary

The user provider

<a name='P-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-Index'></a>
### Index `property`

##### Summary

Gets the value of the index

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-DeleteAsync-`0-'></a>
### DeleteAsync(id) `method`

##### Summary

Deletes the index

##### Returns

A task containing an error or of deleted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`0](#T-`0 '`0') | The id |

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-DeleteManyAsync-System-Collections-Generic-IEnumerable{`0}-'></a>
### DeleteManyAsync(ids) `method`

##### Summary

Deletes the many using the specified index

##### Returns

A task containing an error or of deleted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ids | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`0}') | The ids |

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-GetAsync-`0-'></a>
### GetAsync(id) `method`

##### Summary

Gets the index

##### Returns

A task containing an error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`0](#T-`0 '`0') | The id |

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-GetElasticClient'></a>
### GetElasticClient() `method`

##### Summary

Gets the elastic client

##### Returns

The client

##### Parameters

This method has no parameters.

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-IndexAsync-`1-'></a>
### IndexAsync(entity) `method`

##### Summary

Indexes the index

##### Returns

A task containing an error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`1](#T-`1 '`1') | The entity |

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-IndexManyAsync-System-Collections-Generic-IEnumerable{`1}-'></a>
### IndexManyAsync(entities) `method`

##### Summary

Indexes the many using the specified index

##### Returns

A task containing an error or of i enumerable t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entities | [System.Collections.Generic.IEnumerable{\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{`1}') | The entities |

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-SearchAsync-Elastic-Clients-Elasticsearch-QueryDsl-Query,System-Int32,System-Int32-'></a>
### SearchAsync(query,from,size) `method`

##### Summary

Searches the index

##### Returns

A task containing an enumerable of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [Elastic.Clients.Elasticsearch.QueryDsl.Query](#T-Elastic-Clients-Elasticsearch-QueryDsl-Query 'Elastic.Clients.Elasticsearch.QueryDsl.Query') | The query |
| from | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The from |
| size | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size |

<a name='M-CleanCore-Application-Handlers-BaseElasticCommandHandler`3-UpdateAsync-`1-'></a>
### UpdateAsync(entity) `method`

##### Summary

Updates the index

##### Returns

A task containing an error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`1](#T-`1 '`1') | The entity |

<a name='T-CleanCore-Application-Handlers-CreateElasticEntityCommandHandler`3'></a>
## CreateElasticEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The create elastic entity command handler class

##### See Also

- [CleanCore.Application.Handlers.BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-CreateElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [CreateElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-CreateElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.CreateElasticEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='M-CleanCore-Application-Handlers-CreateElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-CreateEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.CreateEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-CreateEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.CreateEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Handlers-CreateEntityCommandHandler`3'></a>
## CreateEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The create entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-CreateEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [CreateEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-CreateEntityCommandHandler`3 'CleanCore.Application.Handlers.CreateEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-CreateEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-CreateEntityCommandHandler`3-Handle-CleanCore-Application-Commands-CreateEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.CreateEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-CreateEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.CreateEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-CreateEntityCommand`3'></a>
## CreateEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The create entity command

<a name='M-CleanCore-Application-Commands-CreateEntityCommand`3-#ctor-CleanCore-Domain-Common-ICreateEntityDto{`0,`1,`2}-'></a>
### #ctor() `constructor`

##### Summary

The create entity command

##### Parameters

This constructor has no parameters.

<a name='T-CleanCore-Application-Handlers-DeleteElasticEntityCommandHandler`3'></a>
## DeleteElasticEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The delete elastic entity command handler class

##### See Also

- [CleanCore.Application.Handlers.BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-DeleteElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [DeleteElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteElasticEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='M-CleanCore-Application-Handlers-DeleteElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.DeleteEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-DeleteEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.DeleteEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3'></a>
## DeleteEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The delete entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DeleteEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-DeleteEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.DeleteEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-DeleteEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.DeleteEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-DeleteEntityCommand`3'></a>
## DeleteEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The delete entity command

<a name='M-CleanCore-Application-Commands-DeleteEntityCommand`3-#ctor-`0-'></a>
### #ctor() `constructor`

##### Summary

The delete entity command

##### Parameters

This constructor has no parameters.

<a name='T-CleanCore-Application-Handlers-DeleteManyElasticEntityCommandHandler`3'></a>
## DeleteManyElasticEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The delete many elastic entity command handler class

##### See Also

- [CleanCore.Application.Handlers.BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-DeleteManyElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [DeleteManyElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteManyElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteManyElasticEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='M-CleanCore-Application-Handlers-DeleteManyElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of deleted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.DeleteManyEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-DeleteManyEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.DeleteManyEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3'></a>
## DeleteManyEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The delete many entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [DeleteManyEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3 'CleanCore.Application.Handlers.DeleteManyEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-DeleteManyEntityCommandHandler`3-Handle-CleanCore-Application-Commands-DeleteManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of deleted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.DeleteManyEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-DeleteManyEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.DeleteManyEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-DeleteManyEntityCommand`3'></a>
## DeleteManyEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The delete many entity command

<a name='M-CleanCore-Application-Commands-DeleteManyEntityCommand`3-#ctor-System-Collections-Generic-IEnumerable{`0}-'></a>
### #ctor() `constructor`

##### Summary

The delete many entity command

##### Parameters

This constructor has no parameters.

<a name='T-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3'></a>
## FindAllEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The find all entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [FindAllEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3 'CleanCore.Application.Handlers.FindAllEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-FindAllEntityCommandHandler`3-Handle-CleanCore-Application-Commands-FindAllEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an enumerable of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.FindAllEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-FindAllEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.FindAllEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-FindAllEntityCommand`3'></a>
## FindAllEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The find all entity command

<a name='M-CleanCore-Application-Commands-FindAllEntityCommand`3-#ctor'></a>
### #ctor() `constructor`

##### Summary

The find all entity command

##### Parameters

This constructor has no parameters.

<a name='T-CleanCore-Application-Handlers-FindElasticEntityCommandHandler`3'></a>
## FindElasticEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The find elastic entity command handler class

##### See Also

- [CleanCore.Application.Handlers.BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-FindElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [FindElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-FindElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.FindElasticEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='M-CleanCore-Application-Handlers-FindElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-FindEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.FindEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-FindEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.FindEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Handlers-FindEntityCommandHandler`3'></a>
## FindEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The find entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-FindEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [FindEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-FindEntityCommandHandler`3 'CleanCore.Application.Handlers.FindEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-FindEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-FindEntityCommandHandler`3-Handle-CleanCore-Application-Commands-FindEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.FindEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-FindEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.FindEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-FindEntityCommand`3'></a>
## FindEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The find entity command

<a name='M-CleanCore-Application-Commands-FindEntityCommand`3-#ctor-`0-'></a>
### #ctor() `constructor`

##### Summary

The find entity command

##### Parameters

This constructor has no parameters.

<a name='T-CleanCore-Application-Services-IOrganizationProvider`1'></a>
## IOrganizationProvider\`1 `type`

##### Namespace

CleanCore.Application.Services

##### Summary

The organization provider interface

<a name='M-CleanCore-Application-Services-IOrganizationProvider`1-GetOrganization'></a>
### GetOrganization() `method`

##### Summary

Gets the organization

##### Returns

An error or of i organization t organization id

##### Parameters

This method has no parameters.

<a name='T-CleanCore-Application-Services-IUserProvider'></a>
## IUserProvider `type`

##### Namespace

CleanCore.Application.Services

##### Summary

The user provider interface

<a name='M-CleanCore-Application-Services-IUserProvider-GetCurrentUser'></a>
### GetCurrentUser() `method`

##### Summary

Gets the current user

##### Returns

An error or of i user

##### Parameters

This method has no parameters.

<a name='T-CleanCore-Application-Handlers-ModifyElasticEntityCommandHandler`3'></a>
## ModifyElasticEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The modify elastic entity command handler class

##### See Also

- [CleanCore.Application.Handlers.BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-ModifyElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [ModifyElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-ModifyElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.ModifyElasticEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='M-CleanCore-Application-Handlers-ModifyElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-ModifyEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.ModifyEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-ModifyEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.ModifyEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3'></a>
## ModifyEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The modify entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [ModifyEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3 'CleanCore.Application.Handlers.ModifyEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-ModifyEntityCommandHandler`3-Handle-CleanCore-Application-Commands-ModifyEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.ModifyEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-ModifyEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.ModifyEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-ModifyEntityCommand`3'></a>
## ModifyEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The modify entity command

<a name='M-CleanCore-Application-Commands-ModifyEntityCommand`3-#ctor-`2-'></a>
### #ctor() `constructor`

##### Summary

The modify entity command

##### Parameters

This constructor has no parameters.

<a name='T-CleanCore-Application-Handlers-UpsertElasticEntityCommandHandler`3'></a>
## UpsertElasticEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The upsert elastic entity command handler class

##### See Also

- [CleanCore.Application.Handlers.BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-UpsertElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [UpsertElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertElasticEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='M-CleanCore-Application-Handlers-UpsertElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.UpsertEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-UpsertEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.UpsertEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3'></a>
## UpsertEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The upsert entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [UpsertEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-UpsertEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.UpsertEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-UpsertEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.UpsertEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-UpsertEntityCommand`3'></a>
## UpsertEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The upsert entity command

<a name='M-CleanCore-Application-Commands-UpsertEntityCommand`3-#ctor-`2-'></a>
### #ctor() `constructor`

##### Summary

The upsert entity command

##### Parameters

This constructor has no parameters.

<a name='T-CleanCore-Application-Handlers-UpsertManyElasticEntityCommandHandler`3'></a>
## UpsertManyElasticEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The upsert many elastic entity command handler class

##### See Also

- [CleanCore.Application.Handlers.BaseElasticCommandHandler\`3](#T-CleanCore-Application-Handlers-BaseElasticCommandHandler`3 'CleanCore.Application.Handlers.BaseElasticCommandHandler`3')
- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-UpsertManyElasticEntityCommandHandler`3-#ctor-Microsoft-Extensions-Configuration-IConfiguration,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(configuration,userProvider) `constructor`

##### Summary

Initializes a new instance of the [UpsertManyElasticEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertManyElasticEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertManyElasticEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | The configuration |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='M-CleanCore-Application-Handlers-UpsertManyElasticEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of i enumerable t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.UpsertManyEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-UpsertManyEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.UpsertManyEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3'></a>
## UpsertManyEntityCommandHandler\`3 `type`

##### Namespace

CleanCore.Application.Handlers

##### Summary

The upsert many entity command handler class

##### See Also

- [MediatR.IRequestHandler\`2](#T-MediatR-IRequestHandler`2 'MediatR.IRequestHandler`2')

<a name='M-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [UpsertManyEntityCommandHandler\`3](#T-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3 'CleanCore.Application.Handlers.UpsertManyEntityCommandHandler`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='F-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3-_context'></a>
### _context `constants`

##### Summary

The context

<a name='M-CleanCore-Application-Handlers-UpsertManyEntityCommandHandler`3-Handle-CleanCore-Application-Commands-UpsertManyEntityCommand{`0,`1,`2},System-Threading-CancellationToken-'></a>
### Handle(request,cancellationToken) `method`

##### Summary

Handles the request

##### Returns

A task containing an error or of i enumerable t dto

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [CleanCore.Application.Commands.UpsertManyEntityCommand{\`0,\`1,\`2}](#T-CleanCore-Application-Commands-UpsertManyEntityCommand{`0,`1,`2} 'CleanCore.Application.Commands.UpsertManyEntityCommand{`0,`1,`2}') | The request |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Application-Commands-UpsertManyEntityCommand`3'></a>
## UpsertManyEntityCommand\`3 `type`

##### Namespace

CleanCore.Application.Commands

##### Summary

The upsert many entity command

<a name='M-CleanCore-Application-Commands-UpsertManyEntityCommand`3-#ctor-System-Collections-Generic-IEnumerable{`2}-'></a>
### #ctor() `constructor`

##### Summary

The upsert many entity command

##### Parameters

This constructor has no parameters.
