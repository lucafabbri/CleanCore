<a name='assembly'></a>
# CleanCore.Infrastructure

## Contents

- [BaseEntitySaveChangesInterceptor](#T-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor')
  - [#ctor(dateTime,userProvider)](#M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-#ctor-System-TimeProvider,CleanCore-Application-Services-IUserProvider- 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor.#ctor(System.TimeProvider,CleanCore.Application.Services.IUserProvider)')
  - [_dateTime](#F-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-_dateTime 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor._dateTime')
  - [_userProvider](#F-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-_userProvider 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor._userProvider')
  - [SavingChanges(eventData,result)](#M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-SavingChanges-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32}- 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor.SavingChanges(Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData,Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32})')
  - [SavingChangesAsync(eventData,result,cancellationToken)](#M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-SavingChangesAsync-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32},System-Threading-CancellationToken- 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor.SavingChangesAsync(Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData,Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32},System.Threading.CancellationToken)')
  - [UpdateEntities(context)](#M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-UpdateEntities-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor.UpdateEntities(Microsoft.EntityFrameworkCore.DbContext)')
- [DispatchDomainEventsInterceptor](#T-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor 'CleanCore.Infrastructure.Data.Interceptors.DispatchDomainEventsInterceptor')
  - [#ctor(mediator)](#M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-#ctor-MediatR-IMediator- 'CleanCore.Infrastructure.Data.Interceptors.DispatchDomainEventsInterceptor.#ctor(MediatR.IMediator)')
  - [_mediator](#F-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-_mediator 'CleanCore.Infrastructure.Data.Interceptors.DispatchDomainEventsInterceptor._mediator')
  - [DispatchDomainEvents(context)](#M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-DispatchDomainEvents-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Infrastructure.Data.Interceptors.DispatchDomainEventsInterceptor.DispatchDomainEvents(Microsoft.EntityFrameworkCore.DbContext)')
  - [SavingChanges(eventData,result)](#M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-SavingChanges-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32}- 'CleanCore.Infrastructure.Data.Interceptors.DispatchDomainEventsInterceptor.SavingChanges(Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData,Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32})')
  - [SavingChangesAsync(eventData,result,cancellationToken)](#M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-SavingChangesAsync-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32},System-Threading-CancellationToken- 'CleanCore.Infrastructure.Data.Interceptors.DispatchDomainEventsInterceptor.SavingChangesAsync(Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData,Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32},System.Threading.CancellationToken)')
- [EntityEntryExtensions](#T-CleanCore-Infrastructure-Data-Interceptors-EntityEntryExtensions 'CleanCore.Infrastructure.Data.Interceptors.EntityEntryExtensions')
  - [HasChangedOwnedEntities(entry)](#M-CleanCore-Infrastructure-Data-Interceptors-EntityEntryExtensions-HasChangedOwnedEntities-Microsoft-EntityFrameworkCore-ChangeTracking-EntityEntry- 'CleanCore.Infrastructure.Data.Interceptors.EntityEntryExtensions.HasChangedOwnedEntities(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry)')
- [OrganizationEntitySaveChangesInterceptor\`1](#T-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1 'CleanCore.Infrastructure.Data.Interceptors.OrganizationEntitySaveChangesInterceptor`1')
  - [#ctor(organizationProvider)](#M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-#ctor-CleanCore-Application-Services-IOrganizationProvider{`0}- 'CleanCore.Infrastructure.Data.Interceptors.OrganizationEntitySaveChangesInterceptor`1.#ctor(CleanCore.Application.Services.IOrganizationProvider{`0})')
  - [_organizationProvider](#F-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-_organizationProvider 'CleanCore.Infrastructure.Data.Interceptors.OrganizationEntitySaveChangesInterceptor`1._organizationProvider')
  - [SavingChanges(eventData,result)](#M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-SavingChanges-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32}- 'CleanCore.Infrastructure.Data.Interceptors.OrganizationEntitySaveChangesInterceptor`1.SavingChanges(Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData,Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32})')
  - [SavingChangesAsync(eventData,result,cancellationToken)](#M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-SavingChangesAsync-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32},System-Threading-CancellationToken- 'CleanCore.Infrastructure.Data.Interceptors.OrganizationEntitySaveChangesInterceptor`1.SavingChangesAsync(Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData,Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32},System.Threading.CancellationToken)')
  - [UpdateEntities(context)](#M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-UpdateEntities-Microsoft-EntityFrameworkCore-DbContext- 'CleanCore.Infrastructure.Data.Interceptors.OrganizationEntitySaveChangesInterceptor`1.UpdateEntities(Microsoft.EntityFrameworkCore.DbContext)')

<a name='T-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor'></a>
## BaseEntitySaveChangesInterceptor `type`

##### Namespace

CleanCore.Infrastructure.Data.Interceptors

##### Summary

The base entity save changes interceptor class

##### See Also

- [Microsoft.EntityFrameworkCore.Diagnostics.SaveChangesInterceptor](#T-Microsoft-EntityFrameworkCore-Diagnostics-SaveChangesInterceptor 'Microsoft.EntityFrameworkCore.Diagnostics.SaveChangesInterceptor')

<a name='M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-#ctor-System-TimeProvider,CleanCore-Application-Services-IUserProvider-'></a>
### #ctor(dateTime,userProvider) `constructor`

##### Summary

Initializes a new instance of the [BaseEntitySaveChangesInterceptor](#T-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor 'CleanCore.Infrastructure.Data.Interceptors.BaseEntitySaveChangesInterceptor') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateTime | [System.TimeProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeProvider 'System.TimeProvider') | The date time |
| userProvider | [CleanCore.Application.Services.IUserProvider](#T-CleanCore-Application-Services-IUserProvider 'CleanCore.Application.Services.IUserProvider') | The user provider |

<a name='F-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-_dateTime'></a>
### _dateTime `constants`

##### Summary

The date time

<a name='F-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-_userProvider'></a>
### _userProvider `constants`

##### Summary

The user provider

<a name='M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-SavingChanges-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32}-'></a>
### SavingChanges(eventData,result) `method`

##### Summary

Savings the changes using the specified event data

##### Returns

An interception result of int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventData | [Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData](#T-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData 'Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData') | The event data |
| result | [Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}](#T-Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32} 'Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}') | The result |

<a name='M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-SavingChangesAsync-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32},System-Threading-CancellationToken-'></a>
### SavingChangesAsync(eventData,result,cancellationToken) `method`

##### Summary

Savings the changes using the specified event data

##### Returns

A value task of interception result int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventData | [Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData](#T-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData 'Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData') | The event data |
| result | [Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}](#T-Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32} 'Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}') | The result |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='M-CleanCore-Infrastructure-Data-Interceptors-BaseEntitySaveChangesInterceptor-UpdateEntities-Microsoft-EntityFrameworkCore-DbContext-'></a>
### UpdateEntities(context) `method`

##### Summary

Updates the entities using the specified context

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='T-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor'></a>
## DispatchDomainEventsInterceptor `type`

##### Namespace

CleanCore.Infrastructure.Data.Interceptors

##### Summary

The dispatch domain events interceptor class

##### See Also

- [Microsoft.EntityFrameworkCore.Diagnostics.SaveChangesInterceptor](#T-Microsoft-EntityFrameworkCore-Diagnostics-SaveChangesInterceptor 'Microsoft.EntityFrameworkCore.Diagnostics.SaveChangesInterceptor')

<a name='M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-#ctor-MediatR-IMediator-'></a>
### #ctor(mediator) `constructor`

##### Summary

Initializes a new instance of the [DispatchDomainEventsInterceptor](#T-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor 'CleanCore.Infrastructure.Data.Interceptors.DispatchDomainEventsInterceptor') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mediator | [MediatR.IMediator](#T-MediatR-IMediator 'MediatR.IMediator') | The mediator |

<a name='F-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-_mediator'></a>
### _mediator `constants`

##### Summary

The mediator

<a name='M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-DispatchDomainEvents-Microsoft-EntityFrameworkCore-DbContext-'></a>
### DispatchDomainEvents(context) `method`

##### Summary

Dispatches the domain events using the specified context

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |

<a name='M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-SavingChanges-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32}-'></a>
### SavingChanges(eventData,result) `method`

##### Summary

Savings the changes using the specified event data

##### Returns

An interception result of int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventData | [Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData](#T-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData 'Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData') | The event data |
| result | [Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}](#T-Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32} 'Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}') | The result |

<a name='M-CleanCore-Infrastructure-Data-Interceptors-DispatchDomainEventsInterceptor-SavingChangesAsync-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32},System-Threading-CancellationToken-'></a>
### SavingChangesAsync(eventData,result,cancellationToken) `method`

##### Summary

Savings the changes using the specified event data

##### Returns

A value task of interception result int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventData | [Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData](#T-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData 'Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData') | The event data |
| result | [Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}](#T-Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32} 'Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}') | The result |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='T-CleanCore-Infrastructure-Data-Interceptors-EntityEntryExtensions'></a>
## EntityEntryExtensions `type`

##### Namespace

CleanCore.Infrastructure.Data.Interceptors

##### Summary

The entity entry extensions class

<a name='M-CleanCore-Infrastructure-Data-Interceptors-EntityEntryExtensions-HasChangedOwnedEntities-Microsoft-EntityFrameworkCore-ChangeTracking-EntityEntry-'></a>
### HasChangedOwnedEntities(entry) `method`

##### Summary

Hases the changed owned entities using the specified entry

##### Returns

The bool

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry](#T-Microsoft-EntityFrameworkCore-ChangeTracking-EntityEntry 'Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry') | The entry |

<a name='T-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1'></a>
## OrganizationEntitySaveChangesInterceptor\`1 `type`

##### Namespace

CleanCore.Infrastructure.Data.Interceptors

##### Summary

The organization entity save changes interceptor class

##### See Also

- [Microsoft.EntityFrameworkCore.Diagnostics.SaveChangesInterceptor](#T-Microsoft-EntityFrameworkCore-Diagnostics-SaveChangesInterceptor 'Microsoft.EntityFrameworkCore.Diagnostics.SaveChangesInterceptor')

<a name='M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-#ctor-CleanCore-Application-Services-IOrganizationProvider{`0}-'></a>
### #ctor(organizationProvider) `constructor`

##### Summary

Initializes a new instance of the [OrganizationEntitySaveChangesInterceptor\`1](#T-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1 'CleanCore.Infrastructure.Data.Interceptors.OrganizationEntitySaveChangesInterceptor`1') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| organizationProvider | [CleanCore.Application.Services.IOrganizationProvider{\`0}](#T-CleanCore-Application-Services-IOrganizationProvider{`0} 'CleanCore.Application.Services.IOrganizationProvider{`0}') | The organization provider |

<a name='F-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-_organizationProvider'></a>
### _organizationProvider `constants`

##### Summary

The organization provider

<a name='M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-SavingChanges-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32}-'></a>
### SavingChanges(eventData,result) `method`

##### Summary

Savings the changes using the specified event data

##### Returns

An interception result of int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventData | [Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData](#T-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData 'Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData') | The event data |
| result | [Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}](#T-Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32} 'Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}') | The result |

<a name='M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-SavingChangesAsync-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData,Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32},System-Threading-CancellationToken-'></a>
### SavingChangesAsync(eventData,result,cancellationToken) `method`

##### Summary

Savings the changes using the specified event data

##### Returns

A value task of interception result int

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventData | [Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData](#T-Microsoft-EntityFrameworkCore-Diagnostics-DbContextEventData 'Microsoft.EntityFrameworkCore.Diagnostics.DbContextEventData') | The event data |
| result | [Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}](#T-Microsoft-EntityFrameworkCore-Diagnostics-InterceptionResult{System-Int32} 'Microsoft.EntityFrameworkCore.Diagnostics.InterceptionResult{System.Int32}') | The result |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | The cancellation token |

<a name='M-CleanCore-Infrastructure-Data-Interceptors-OrganizationEntitySaveChangesInterceptor`1-UpdateEntities-Microsoft-EntityFrameworkCore-DbContext-'></a>
### UpdateEntities(context) `method`

##### Summary

Updates the entities using the specified context

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context |
