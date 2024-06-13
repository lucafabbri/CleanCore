<a name='assembly'></a>
# CleanCore.Domain

## Contents

- [BaseEntity](#T-CleanCore-Domain-Common-BaseEntity 'CleanCore.Domain.Common.BaseEntity')
  - [_domainEvents](#F-CleanCore-Domain-Common-BaseEntity-_domainEvents 'CleanCore.Domain.Common.BaseEntity._domainEvents')
  - [CreatedAt](#P-CleanCore-Domain-Common-BaseEntity-CreatedAt 'CleanCore.Domain.Common.BaseEntity.CreatedAt')
  - [CreatedBy](#P-CleanCore-Domain-Common-BaseEntity-CreatedBy 'CleanCore.Domain.Common.BaseEntity.CreatedBy')
  - [DeletedAt](#P-CleanCore-Domain-Common-BaseEntity-DeletedAt 'CleanCore.Domain.Common.BaseEntity.DeletedAt')
  - [DeletedBy](#P-CleanCore-Domain-Common-BaseEntity-DeletedBy 'CleanCore.Domain.Common.BaseEntity.DeletedBy')
  - [DomainEvents](#P-CleanCore-Domain-Common-BaseEntity-DomainEvents 'CleanCore.Domain.Common.BaseEntity.DomainEvents')
  - [IsDeleted](#P-CleanCore-Domain-Common-BaseEntity-IsDeleted 'CleanCore.Domain.Common.BaseEntity.IsDeleted')
  - [LastModifiedAt](#P-CleanCore-Domain-Common-BaseEntity-LastModifiedAt 'CleanCore.Domain.Common.BaseEntity.LastModifiedAt')
  - [LastModifiedBy](#P-CleanCore-Domain-Common-BaseEntity-LastModifiedBy 'CleanCore.Domain.Common.BaseEntity.LastModifiedBy')
  - [ClearDomainEvents()](#M-CleanCore-Domain-Common-BaseEntity-ClearDomainEvents 'CleanCore.Domain.Common.BaseEntity.ClearDomainEvents')
  - [Created(by,when)](#M-CleanCore-Domain-Common-BaseEntity-Created-System-String,System-Nullable{System-DateTimeOffset}- 'CleanCore.Domain.Common.BaseEntity.Created(System.String,System.Nullable{System.DateTimeOffset})')
  - [Deleted(by,when)](#M-CleanCore-Domain-Common-BaseEntity-Deleted-System-String,System-Nullable{System-DateTimeOffset}- 'CleanCore.Domain.Common.BaseEntity.Deleted(System.String,System.Nullable{System.DateTimeOffset})')
  - [Modified(by,when)](#M-CleanCore-Domain-Common-BaseEntity-Modified-System-String,System-Nullable{System-DateTimeOffset}- 'CleanCore.Domain.Common.BaseEntity.Modified(System.String,System.Nullable{System.DateTimeOffset})')
- [BaseEntityAndDto\`2](#T-CleanCore-Domain-Common-BaseEntityAndDto`2 'CleanCore.Domain.Common.BaseEntityAndDto`2')
  - [#ctor()](#M-CleanCore-Domain-Common-BaseEntityAndDto`2-#ctor 'CleanCore.Domain.Common.BaseEntityAndDto`2.#ctor')
  - [#ctor(id)](#M-CleanCore-Domain-Common-BaseEntityAndDto`2-#ctor-`0- 'CleanCore.Domain.Common.BaseEntityAndDto`2.#ctor(`0)')
  - [ToDto()](#M-CleanCore-Domain-Common-BaseEntityAndDto`2-ToDto 'CleanCore.Domain.Common.BaseEntityAndDto`2.ToDto')
  - [ToEntity()](#M-CleanCore-Domain-Common-BaseEntityAndDto`2-ToEntity 'CleanCore.Domain.Common.BaseEntityAndDto`2.ToEntity')
- [BaseEntityEvent](#T-CleanCore-Domain-Common-BaseEntityEvent 'CleanCore.Domain.Common.BaseEntityEvent')
- [BaseEntityEvent\`3](#T-CleanCore-Domain-Common-BaseEntityEvent`3 'CleanCore.Domain.Common.BaseEntityEvent`3')
  - [#ctor(entity)](#M-CleanCore-Domain-Common-BaseEntityEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}- 'CleanCore.Domain.Common.BaseEntityEvent`3.#ctor(CleanCore.Domain.Common.BaseEntity{`0,`1,`2})')
  - [Entity](#P-CleanCore-Domain-Common-BaseEntityEvent`3-Entity 'CleanCore.Domain.Common.BaseEntityEvent`3.Entity')
- [BaseEntity\`3](#T-CleanCore-Domain-Common-BaseEntity`3 'CleanCore.Domain.Common.BaseEntity`3')
  - [#ctor()](#M-CleanCore-Domain-Common-BaseEntity`3-#ctor 'CleanCore.Domain.Common.BaseEntity`3.#ctor')
  - [#ctor(id)](#M-CleanCore-Domain-Common-BaseEntity`3-#ctor-`0- 'CleanCore.Domain.Common.BaseEntity`3.#ctor(`0)')
  - [Id](#P-CleanCore-Domain-Common-BaseEntity`3-Id 'CleanCore.Domain.Common.BaseEntity`3.Id')
  - [AddDomainEvent(domainEvent)](#M-CleanCore-Domain-Common-BaseEntity`3-AddDomainEvent-CleanCore-Domain-Common-BaseEntityEvent{`0,`1,`2}- 'CleanCore.Domain.Common.BaseEntity`3.AddDomainEvent(CleanCore.Domain.Common.BaseEntityEvent{`0,`1,`2})')
  - [InnerUpdate(entity)](#M-CleanCore-Domain-Common-BaseEntity`3-InnerUpdate-`1- 'CleanCore.Domain.Common.BaseEntity`3.InnerUpdate(`1)')
  - [Mutate(mutation)](#M-CleanCore-Domain-Common-BaseEntity`3-Mutate-System-Func{`1,ErrorOr-ErrorOr{`1}}- 'CleanCore.Domain.Common.BaseEntity`3.Mutate(System.Func{`1,ErrorOr.ErrorOr{`1}})')
  - [RemoveDomainEvent(domainEvent)](#M-CleanCore-Domain-Common-BaseEntity`3-RemoveDomainEvent-CleanCore-Domain-Common-BaseEntityEvent{`0,`1,`2}- 'CleanCore.Domain.Common.BaseEntity`3.RemoveDomainEvent(CleanCore.Domain.Common.BaseEntityEvent{`0,`1,`2})')
  - [ToDto()](#M-CleanCore-Domain-Common-BaseEntity`3-ToDto 'CleanCore.Domain.Common.BaseEntity`3.ToDto')
  - [Update(entity)](#M-CleanCore-Domain-Common-BaseEntity`3-Update-`1- 'CleanCore.Domain.Common.BaseEntity`3.Update(`1)')
  - [Validate()](#M-CleanCore-Domain-Common-BaseEntity`3-Validate 'CleanCore.Domain.Common.BaseEntity`3.Validate')
- [BaseIntEntityAndDto\`1](#T-CleanCore-Domain-Common-BaseIntEntityAndDto`1 'CleanCore.Domain.Common.BaseIntEntityAndDto`1')
  - [#ctor()](#M-CleanCore-Domain-Common-BaseIntEntityAndDto`1-#ctor 'CleanCore.Domain.Common.BaseIntEntityAndDto`1.#ctor')
  - [#ctor(id)](#M-CleanCore-Domain-Common-BaseIntEntityAndDto`1-#ctor-System-Int32- 'CleanCore.Domain.Common.BaseIntEntityAndDto`1.#ctor(System.Int32)')
- [BaseIntEntity\`2](#T-CleanCore-Domain-Common-BaseIntEntity`2 'CleanCore.Domain.Common.BaseIntEntity`2')
  - [#ctor()](#M-CleanCore-Domain-Common-BaseIntEntity`2-#ctor 'CleanCore.Domain.Common.BaseIntEntity`2.#ctor')
  - [#ctor(id)](#M-CleanCore-Domain-Common-BaseIntEntity`2-#ctor-System-Int32- 'CleanCore.Domain.Common.BaseIntEntity`2.#ctor(System.Int32)')
- [BaseOrganizationEntity\`4](#T-CleanCore-Domain-Common-BaseOrganizationEntity`4 'CleanCore.Domain.Common.BaseOrganizationEntity`4')
  - [#ctor(id,organizationId)](#M-CleanCore-Domain-Common-BaseOrganizationEntity`4-#ctor-`0,`1- 'CleanCore.Domain.Common.BaseOrganizationEntity`4.#ctor(`0,`1)')
  - [OrganizationId](#P-CleanCore-Domain-Common-BaseOrganizationEntity`4-OrganizationId 'CleanCore.Domain.Common.BaseOrganizationEntity`4.OrganizationId')
- [EntityCreationEvent\`3](#T-CleanCore-Domain-Events-EntityCreationEvent`3 'CleanCore.Domain.Events.EntityCreationEvent`3')
  - [#ctor(entity)](#M-CleanCore-Domain-Events-EntityCreationEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}- 'CleanCore.Domain.Events.EntityCreationEvent`3.#ctor(CleanCore.Domain.Common.BaseEntity{`0,`1,`2})')
- [EntityDeletedEvent\`3](#T-CleanCore-Domain-Events-EntityDeletedEvent`3 'CleanCore.Domain.Events.EntityDeletedEvent`3')
  - [#ctor(entity)](#M-CleanCore-Domain-Events-EntityDeletedEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}- 'CleanCore.Domain.Events.EntityDeletedEvent`3.#ctor(CleanCore.Domain.Common.BaseEntity{`0,`1,`2})')
- [EntityDto\`3](#T-CleanCore-Domain-Common-EntityDto`3 'CleanCore.Domain.Common.EntityDto`3')
  - [CreatedAt](#P-CleanCore-Domain-Common-EntityDto`3-CreatedAt 'CleanCore.Domain.Common.EntityDto`3.CreatedAt')
  - [CreatedBy](#P-CleanCore-Domain-Common-EntityDto`3-CreatedBy 'CleanCore.Domain.Common.EntityDto`3.CreatedBy')
  - [DeletedAt](#P-CleanCore-Domain-Common-EntityDto`3-DeletedAt 'CleanCore.Domain.Common.EntityDto`3.DeletedAt')
  - [DeletedBy](#P-CleanCore-Domain-Common-EntityDto`3-DeletedBy 'CleanCore.Domain.Common.EntityDto`3.DeletedBy')
  - [Id](#P-CleanCore-Domain-Common-EntityDto`3-Id 'CleanCore.Domain.Common.EntityDto`3.Id')
  - [LastModifiedAt](#P-CleanCore-Domain-Common-EntityDto`3-LastModifiedAt 'CleanCore.Domain.Common.EntityDto`3.LastModifiedAt')
  - [LastModifiedBy](#P-CleanCore-Domain-Common-EntityDto`3-LastModifiedBy 'CleanCore.Domain.Common.EntityDto`3.LastModifiedBy')
  - [ToEntity()](#M-CleanCore-Domain-Common-EntityDto`3-ToEntity 'CleanCore.Domain.Common.EntityDto`3.ToEntity')
- [EntityModifiedEvent\`3](#T-CleanCore-Domain-Events-EntityModifiedEvent`3 'CleanCore.Domain.Events.EntityModifiedEvent`3')
  - [#ctor(entity)](#M-CleanCore-Domain-Events-EntityModifiedEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}- 'CleanCore.Domain.Events.EntityModifiedEvent`3.#ctor(CleanCore.Domain.Common.BaseEntity{`0,`1,`2})')
- [ErrorOrExtension](#T-CleanCore-Core-Extensions-ErrorOrExtension 'CleanCore.Core.Extensions.ErrorOrExtension')
  - [ValueOrNull\`\`1(result)](#M-CleanCore-Core-Extensions-ErrorOrExtension-ValueOrNull``1-ErrorOr-ErrorOr{``0}- 'CleanCore.Core.Extensions.ErrorOrExtension.ValueOrNull``1(ErrorOr.ErrorOr{``0})')
- [ICreateEntityDto\`3](#T-CleanCore-Domain-Common-ICreateEntityDto`3 'CleanCore.Domain.Common.ICreateEntityDto`3')
  - [ToEntity()](#M-CleanCore-Domain-Common-ICreateEntityDto`3-ToEntity 'CleanCore.Domain.Common.ICreateEntityDto`3.ToEntity')
- [IEntityDto\`3](#T-CleanCore-Domain-Common-IEntityDto`3 'CleanCore.Domain.Common.IEntityDto`3')
  - [CreatedAt](#P-CleanCore-Domain-Common-IEntityDto`3-CreatedAt 'CleanCore.Domain.Common.IEntityDto`3.CreatedAt')
  - [CreatedBy](#P-CleanCore-Domain-Common-IEntityDto`3-CreatedBy 'CleanCore.Domain.Common.IEntityDto`3.CreatedBy')
  - [DeletedAt](#P-CleanCore-Domain-Common-IEntityDto`3-DeletedAt 'CleanCore.Domain.Common.IEntityDto`3.DeletedAt')
  - [DeletedBy](#P-CleanCore-Domain-Common-IEntityDto`3-DeletedBy 'CleanCore.Domain.Common.IEntityDto`3.DeletedBy')
  - [Id](#P-CleanCore-Domain-Common-IEntityDto`3-Id 'CleanCore.Domain.Common.IEntityDto`3.Id')
  - [LastModifiedAt](#P-CleanCore-Domain-Common-IEntityDto`3-LastModifiedAt 'CleanCore.Domain.Common.IEntityDto`3.LastModifiedAt')
  - [LastModifiedBy](#P-CleanCore-Domain-Common-IEntityDto`3-LastModifiedBy 'CleanCore.Domain.Common.IEntityDto`3.LastModifiedBy')
  - [ToEntity()](#M-CleanCore-Domain-Common-IEntityDto`3-ToEntity 'CleanCore.Domain.Common.IEntityDto`3.ToEntity')
- [IOrganizationEntity\`1](#T-CleanCore-Domain-Common-IOrganizationEntity`1 'CleanCore.Domain.Common.IOrganizationEntity`1')
  - [OrganizationId](#P-CleanCore-Domain-Common-IOrganizationEntity`1-OrganizationId 'CleanCore.Domain.Common.IOrganizationEntity`1.OrganizationId')
- [IOrganization\`1](#T-CleanCore-Domain-Common-IOrganization`1 'CleanCore.Domain.Common.IOrganization`1')
  - [Id](#P-CleanCore-Domain-Common-IOrganization`1-Id 'CleanCore.Domain.Common.IOrganization`1.Id')
  - [Name](#P-CleanCore-Domain-Common-IOrganization`1-Name 'CleanCore.Domain.Common.IOrganization`1.Name')
  - [UserAccess](#P-CleanCore-Domain-Common-IOrganization`1-UserAccess 'CleanCore.Domain.Common.IOrganization`1.UserAccess')
- [IUser](#T-CleanCore-Domain-Common-IUser 'CleanCore.Domain.Common.IUser')
  - [Name](#P-CleanCore-Domain-Common-IUser-Name 'CleanCore.Domain.Common.IUser.Name')
- [IUserOrganizationAccess](#T-CleanCore-Domain-Common-IUserOrganizationAccess 'CleanCore.Domain.Common.IUserOrganizationAccess')
  - [Access](#P-CleanCore-Domain-Common-IUserOrganizationAccess-Access 'CleanCore.Domain.Common.IUserOrganizationAccess.Access')
  - [User](#P-CleanCore-Domain-Common-IUserOrganizationAccess-User 'CleanCore.Domain.Common.IUserOrganizationAccess.User')
- [IUser\`1](#T-CleanCore-Domain-Common-IUser`1 'CleanCore.Domain.Common.IUser`1')
  - [Sub](#P-CleanCore-Domain-Common-IUser`1-Sub 'CleanCore.Domain.Common.IUser`1.Sub')
- [UserOrganizationAccess](#T-CleanCore-Domain-Common-UserOrganizationAccess 'CleanCore.Domain.Common.UserOrganizationAccess')
  - [Full](#F-CleanCore-Domain-Common-UserOrganizationAccess-Full 'CleanCore.Domain.Common.UserOrganizationAccess.Full')
  - [None](#F-CleanCore-Domain-Common-UserOrganizationAccess-None 'CleanCore.Domain.Common.UserOrganizationAccess.None')
  - [Owner](#F-CleanCore-Domain-Common-UserOrganizationAccess-Owner 'CleanCore.Domain.Common.UserOrganizationAccess.Owner')
  - [Read](#F-CleanCore-Domain-Common-UserOrganizationAccess-Read 'CleanCore.Domain.Common.UserOrganizationAccess.Read')
  - [Write](#F-CleanCore-Domain-Common-UserOrganizationAccess-Write 'CleanCore.Domain.Common.UserOrganizationAccess.Write')

<a name='T-CleanCore-Domain-Common-BaseEntity'></a>
## BaseEntity `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base entity class

<a name='F-CleanCore-Domain-Common-BaseEntity-_domainEvents'></a>
### _domainEvents `constants`

##### Summary

The domain events

<a name='P-CleanCore-Domain-Common-BaseEntity-CreatedAt'></a>
### CreatedAt `property`

##### Summary

Gets or sets the value of the created at

<a name='P-CleanCore-Domain-Common-BaseEntity-CreatedBy'></a>
### CreatedBy `property`

##### Summary

Gets or sets the value of the created by

<a name='P-CleanCore-Domain-Common-BaseEntity-DeletedAt'></a>
### DeletedAt `property`

##### Summary

Gets or sets the value of the deleted at

<a name='P-CleanCore-Domain-Common-BaseEntity-DeletedBy'></a>
### DeletedBy `property`

##### Summary

Gets or sets the value of the deleted by

<a name='P-CleanCore-Domain-Common-BaseEntity-DomainEvents'></a>
### DomainEvents `property`

##### Summary

Gets the value of the domain events

<a name='P-CleanCore-Domain-Common-BaseEntity-IsDeleted'></a>
### IsDeleted `property`

##### Summary

Gets the value of the is deleted

<a name='P-CleanCore-Domain-Common-BaseEntity-LastModifiedAt'></a>
### LastModifiedAt `property`

##### Summary

Gets or sets the value of the last modified at

<a name='P-CleanCore-Domain-Common-BaseEntity-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

Gets or sets the value of the last modified by

<a name='M-CleanCore-Domain-Common-BaseEntity-ClearDomainEvents'></a>
### ClearDomainEvents() `method`

##### Summary

Clears the domain events

##### Parameters

This method has no parameters.

<a name='M-CleanCore-Domain-Common-BaseEntity-Created-System-String,System-Nullable{System-DateTimeOffset}-'></a>
### Created(by,when) `method`

##### Summary

Createds the by

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| by | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The by |
| when | [System.Nullable{System.DateTimeOffset}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTimeOffset}') | The when |

<a name='M-CleanCore-Domain-Common-BaseEntity-Deleted-System-String,System-Nullable{System-DateTimeOffset}-'></a>
### Deleted(by,when) `method`

##### Summary

Deleteds the by

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| by | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The by |
| when | [System.Nullable{System.DateTimeOffset}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTimeOffset}') | The when |

<a name='M-CleanCore-Domain-Common-BaseEntity-Modified-System-String,System-Nullable{System-DateTimeOffset}-'></a>
### Modified(by,when) `method`

##### Summary

Modifieds the by

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| by | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The by |
| when | [System.Nullable{System.DateTimeOffset}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTimeOffset}') | The when |

<a name='T-CleanCore-Domain-Common-BaseEntityAndDto`2'></a>
## BaseEntityAndDto\`2 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base entity and dto class

##### See Also

- [CleanCore.Domain.Common.BaseEntity\`3](#T-CleanCore-Domain-Common-BaseEntity`3 'CleanCore.Domain.Common.BaseEntity`3')
- [CleanCore.Domain.Common.IEntityDto\`3](#T-CleanCore-Domain-Common-IEntityDto`3 'CleanCore.Domain.Common.IEntityDto`3')
- [CleanCore.Domain.Common.ICreateEntityDto\`3](#T-CleanCore-Domain-Common-ICreateEntityDto`3 'CleanCore.Domain.Common.ICreateEntityDto`3')

<a name='M-CleanCore-Domain-Common-BaseEntityAndDto`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [BaseEntityAndDto\`2](#T-CleanCore-Domain-Common-BaseEntityAndDto`2 'CleanCore.Domain.Common.BaseEntityAndDto`2') class

##### Parameters

This constructor has no parameters.

<a name='M-CleanCore-Domain-Common-BaseEntityAndDto`2-#ctor-`0-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [BaseEntityAndDto\`2](#T-CleanCore-Domain-Common-BaseEntityAndDto`2 'CleanCore.Domain.Common.BaseEntityAndDto`2') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`0](#T-`0 '`0') | The id |

<a name='M-CleanCore-Domain-Common-BaseEntityAndDto`2-ToDto'></a>
### ToDto() `method`

##### Summary

Returns the dto

##### Returns

The entity

##### Parameters

This method has no parameters.

<a name='M-CleanCore-Domain-Common-BaseEntityAndDto`2-ToEntity'></a>
### ToEntity() `method`

##### Summary

Returns the entity

##### Returns

The entity

##### Parameters

This method has no parameters.

<a name='T-CleanCore-Domain-Common-BaseEntityEvent'></a>
## BaseEntityEvent `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base entity event class

##### See Also

- [MediatR.INotification](#T-MediatR-INotification 'MediatR.INotification')

<a name='T-CleanCore-Domain-Common-BaseEntityEvent`3'></a>
## BaseEntityEvent\`3 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base entity event class

##### See Also

- [CleanCore.Domain.Common.BaseEntityEvent](#T-CleanCore-Domain-Common-BaseEntityEvent 'CleanCore.Domain.Common.BaseEntityEvent')

<a name='M-CleanCore-Domain-Common-BaseEntityEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}-'></a>
### #ctor(entity) `constructor`

##### Summary

Initializes a new instance of the [BaseEntityEvent\`3](#T-CleanCore-Domain-Common-BaseEntityEvent`3 'CleanCore.Domain.Common.BaseEntityEvent`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [CleanCore.Domain.Common.BaseEntity{\`0,\`1,\`2}](#T-CleanCore-Domain-Common-BaseEntity{`0,`1,`2} 'CleanCore.Domain.Common.BaseEntity{`0,`1,`2}') | The entity |

<a name='P-CleanCore-Domain-Common-BaseEntityEvent`3-Entity'></a>
### Entity `property`

##### Summary

Gets or sets the value of the entity

<a name='T-CleanCore-Domain-Common-BaseEntity`3'></a>
## BaseEntity\`3 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base entity class

##### See Also

- [CleanCore.Domain.Common.BaseEntity](#T-CleanCore-Domain-Common-BaseEntity 'CleanCore.Domain.Common.BaseEntity')

<a name='M-CleanCore-Domain-Common-BaseEntity`3-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [BaseEntity\`3](#T-CleanCore-Domain-Common-BaseEntity`3 'CleanCore.Domain.Common.BaseEntity`3') class

##### Parameters

This constructor has no parameters.

<a name='M-CleanCore-Domain-Common-BaseEntity`3-#ctor-`0-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [BaseEntity\`3](#T-CleanCore-Domain-Common-BaseEntity`3 'CleanCore.Domain.Common.BaseEntity`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`0](#T-`0 '`0') | The id |

<a name='P-CleanCore-Domain-Common-BaseEntity`3-Id'></a>
### Id `property`

##### Summary

Gets or sets the value of the id

<a name='M-CleanCore-Domain-Common-BaseEntity`3-AddDomainEvent-CleanCore-Domain-Common-BaseEntityEvent{`0,`1,`2}-'></a>
### AddDomainEvent(domainEvent) `method`

##### Summary

Adds the domain event using the specified domain event

##### Returns

An error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domainEvent | [CleanCore.Domain.Common.BaseEntityEvent{\`0,\`1,\`2}](#T-CleanCore-Domain-Common-BaseEntityEvent{`0,`1,`2} 'CleanCore.Domain.Common.BaseEntityEvent{`0,`1,`2}') | The domain event |

<a name='M-CleanCore-Domain-Common-BaseEntity`3-InnerUpdate-`1-'></a>
### InnerUpdate(entity) `method`

##### Summary

Inners the update using the specified entity

##### Returns

An error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`1](#T-`1 '`1') | The entity |

<a name='M-CleanCore-Domain-Common-BaseEntity`3-Mutate-System-Func{`1,ErrorOr-ErrorOr{`1}}-'></a>
### Mutate(mutation) `method`

##### Summary

Mutates the mutation

##### Returns

An error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mutation | [System.Func{\`1,ErrorOr.ErrorOr{\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`1,ErrorOr.ErrorOr{`1}}') | The mutation |

<a name='M-CleanCore-Domain-Common-BaseEntity`3-RemoveDomainEvent-CleanCore-Domain-Common-BaseEntityEvent{`0,`1,`2}-'></a>
### RemoveDomainEvent(domainEvent) `method`

##### Summary

Removes the domain event using the specified domain event

##### Returns

An error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| domainEvent | [CleanCore.Domain.Common.BaseEntityEvent{\`0,\`1,\`2}](#T-CleanCore-Domain-Common-BaseEntityEvent{`0,`1,`2} 'CleanCore.Domain.Common.BaseEntityEvent{`0,`1,`2}') | The domain event |

<a name='M-CleanCore-Domain-Common-BaseEntity`3-ToDto'></a>
### ToDto() `method`

##### Summary

Returns the dto

##### Returns

The dto

##### Parameters

This method has no parameters.

<a name='M-CleanCore-Domain-Common-BaseEntity`3-Update-`1-'></a>
### Update(entity) `method`

##### Summary

Updates the entity

##### Returns

An error or of t entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [\`1](#T-`1 '`1') | The entity |

<a name='M-CleanCore-Domain-Common-BaseEntity`3-Validate'></a>
### Validate() `method`

##### Summary

Validates this instance

##### Returns

An error or of t entity

##### Parameters

This method has no parameters.

<a name='T-CleanCore-Domain-Common-BaseIntEntityAndDto`1'></a>
## BaseIntEntityAndDto\`1 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base int entity and dto class

##### See Also

- [CleanCore.Domain.Common.BaseEntityAndDto\`2](#T-CleanCore-Domain-Common-BaseEntityAndDto`2 'CleanCore.Domain.Common.BaseEntityAndDto`2')

<a name='M-CleanCore-Domain-Common-BaseIntEntityAndDto`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [BaseIntEntityAndDto\`1](#T-CleanCore-Domain-Common-BaseIntEntityAndDto`1 'CleanCore.Domain.Common.BaseIntEntityAndDto`1') class

##### Parameters

This constructor has no parameters.

<a name='M-CleanCore-Domain-Common-BaseIntEntityAndDto`1-#ctor-System-Int32-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [BaseIntEntityAndDto\`1](#T-CleanCore-Domain-Common-BaseIntEntityAndDto`1 'CleanCore.Domain.Common.BaseIntEntityAndDto`1') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The id |

<a name='T-CleanCore-Domain-Common-BaseIntEntity`2'></a>
## BaseIntEntity\`2 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base int entity class

##### See Also

- [CleanCore.Domain.Common.BaseEntity\`3](#T-CleanCore-Domain-Common-BaseEntity`3 'CleanCore.Domain.Common.BaseEntity`3')

<a name='M-CleanCore-Domain-Common-BaseIntEntity`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [BaseIntEntity\`2](#T-CleanCore-Domain-Common-BaseIntEntity`2 'CleanCore.Domain.Common.BaseIntEntity`2') class

##### Parameters

This constructor has no parameters.

<a name='M-CleanCore-Domain-Common-BaseIntEntity`2-#ctor-System-Int32-'></a>
### #ctor(id) `constructor`

##### Summary

Initializes a new instance of the [BaseIntEntity\`2](#T-CleanCore-Domain-Common-BaseIntEntity`2 'CleanCore.Domain.Common.BaseIntEntity`2') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The id |

<a name='T-CleanCore-Domain-Common-BaseOrganizationEntity`4'></a>
## BaseOrganizationEntity\`4 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The base organization entity class

##### See Also

- [CleanCore.Domain.Common.BaseEntity\`3](#T-CleanCore-Domain-Common-BaseEntity`3 'CleanCore.Domain.Common.BaseEntity`3')
- [CleanCore.Domain.Common.IOrganizationEntity\`1](#T-CleanCore-Domain-Common-IOrganizationEntity`1 'CleanCore.Domain.Common.IOrganizationEntity`1')

<a name='M-CleanCore-Domain-Common-BaseOrganizationEntity`4-#ctor-`0,`1-'></a>
### #ctor(id,organizationId) `constructor`

##### Summary

Initializes a new instance of the [BaseOrganizationEntity\`4](#T-CleanCore-Domain-Common-BaseOrganizationEntity`4 'CleanCore.Domain.Common.BaseOrganizationEntity`4') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [\`0](#T-`0 '`0') | The id |
| organizationId | [\`1](#T-`1 '`1') | The organization id |

<a name='P-CleanCore-Domain-Common-BaseOrganizationEntity`4-OrganizationId'></a>
### OrganizationId `property`

##### Summary

Gets or sets the value of the organization id

<a name='T-CleanCore-Domain-Events-EntityCreationEvent`3'></a>
## EntityCreationEvent\`3 `type`

##### Namespace

CleanCore.Domain.Events

##### Summary

The entity creation event class

##### See Also

- [CleanCore.Domain.Common.BaseEntityEvent\`3](#T-CleanCore-Domain-Common-BaseEntityEvent`3 'CleanCore.Domain.Common.BaseEntityEvent`3')

<a name='M-CleanCore-Domain-Events-EntityCreationEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}-'></a>
### #ctor(entity) `constructor`

##### Summary

Initializes a new instance of the [EntityCreationEvent\`3](#T-CleanCore-Domain-Events-EntityCreationEvent`3 'CleanCore.Domain.Events.EntityCreationEvent`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [CleanCore.Domain.Common.BaseEntity{\`0,\`1,\`2}](#T-CleanCore-Domain-Common-BaseEntity{`0,`1,`2} 'CleanCore.Domain.Common.BaseEntity{`0,`1,`2}') | The entity |

<a name='T-CleanCore-Domain-Events-EntityDeletedEvent`3'></a>
## EntityDeletedEvent\`3 `type`

##### Namespace

CleanCore.Domain.Events

##### Summary

The entity deleted event class

##### See Also

- [CleanCore.Domain.Common.BaseEntityEvent\`3](#T-CleanCore-Domain-Common-BaseEntityEvent`3 'CleanCore.Domain.Common.BaseEntityEvent`3')

<a name='M-CleanCore-Domain-Events-EntityDeletedEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}-'></a>
### #ctor(entity) `constructor`

##### Summary

Initializes a new instance of the [EntityDeletedEvent\`3](#T-CleanCore-Domain-Events-EntityDeletedEvent`3 'CleanCore.Domain.Events.EntityDeletedEvent`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [CleanCore.Domain.Common.BaseEntity{\`0,\`1,\`2}](#T-CleanCore-Domain-Common-BaseEntity{`0,`1,`2} 'CleanCore.Domain.Common.BaseEntity{`0,`1,`2}') | The entity |

<a name='T-CleanCore-Domain-Common-EntityDto`3'></a>
## EntityDto\`3 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The entity dto class

##### See Also

- [CleanCore.Domain.Common.IEntityDto\`3](#T-CleanCore-Domain-Common-IEntityDto`3 'CleanCore.Domain.Common.IEntityDto`3')

<a name='P-CleanCore-Domain-Common-EntityDto`3-CreatedAt'></a>
### CreatedAt `property`

##### Summary

Gets the value of the created at

<a name='P-CleanCore-Domain-Common-EntityDto`3-CreatedBy'></a>
### CreatedBy `property`

##### Summary

Gets the value of the created by

<a name='P-CleanCore-Domain-Common-EntityDto`3-DeletedAt'></a>
### DeletedAt `property`

##### Summary

Gets the value of the deleted at

<a name='P-CleanCore-Domain-Common-EntityDto`3-DeletedBy'></a>
### DeletedBy `property`

##### Summary

Gets the value of the deleted by

<a name='P-CleanCore-Domain-Common-EntityDto`3-Id'></a>
### Id `property`

##### Summary

Gets the value of the id

<a name='P-CleanCore-Domain-Common-EntityDto`3-LastModifiedAt'></a>
### LastModifiedAt `property`

##### Summary

Gets the value of the last modified at

<a name='P-CleanCore-Domain-Common-EntityDto`3-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

Gets the value of the last modified by

<a name='M-CleanCore-Domain-Common-EntityDto`3-ToEntity'></a>
### ToEntity() `method`

##### Summary

Returns the entity

##### Returns

The entity

##### Parameters

This method has no parameters.

<a name='T-CleanCore-Domain-Events-EntityModifiedEvent`3'></a>
## EntityModifiedEvent\`3 `type`

##### Namespace

CleanCore.Domain.Events

##### Summary

The entity modified event class

##### See Also

- [CleanCore.Domain.Common.BaseEntityEvent\`3](#T-CleanCore-Domain-Common-BaseEntityEvent`3 'CleanCore.Domain.Common.BaseEntityEvent`3')

<a name='M-CleanCore-Domain-Events-EntityModifiedEvent`3-#ctor-CleanCore-Domain-Common-BaseEntity{`0,`1,`2}-'></a>
### #ctor(entity) `constructor`

##### Summary

Initializes a new instance of the [EntityModifiedEvent\`3](#T-CleanCore-Domain-Events-EntityModifiedEvent`3 'CleanCore.Domain.Events.EntityModifiedEvent`3') class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entity | [CleanCore.Domain.Common.BaseEntity{\`0,\`1,\`2}](#T-CleanCore-Domain-Common-BaseEntity{`0,`1,`2} 'CleanCore.Domain.Common.BaseEntity{`0,`1,`2}') | The entity |

<a name='T-CleanCore-Core-Extensions-ErrorOrExtension'></a>
## ErrorOrExtension `type`

##### Namespace

CleanCore.Core.Extensions

##### Summary

The error or extension class

<a name='M-CleanCore-Core-Extensions-ErrorOrExtension-ValueOrNull``1-ErrorOr-ErrorOr{``0}-'></a>
### ValueOrNull\`\`1(result) `method`

##### Summary

Values the or null using the specified result

##### Returns

The value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [ErrorOr.ErrorOr{\`\`0}](#T-ErrorOr-ErrorOr{``0} 'ErrorOr.ErrorOr{``0}') | The result |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TValue | The value |

<a name='T-CleanCore-Domain-Common-ICreateEntityDto`3'></a>
## ICreateEntityDto\`3 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The create entity dto interface

<a name='M-CleanCore-Domain-Common-ICreateEntityDto`3-ToEntity'></a>
### ToEntity() `method`

##### Summary

Returns the entity

##### Returns

The entity

##### Parameters

This method has no parameters.

<a name='T-CleanCore-Domain-Common-IEntityDto`3'></a>
## IEntityDto\`3 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The entity dto interface

<a name='P-CleanCore-Domain-Common-IEntityDto`3-CreatedAt'></a>
### CreatedAt `property`

##### Summary

Gets the value of the created at

<a name='P-CleanCore-Domain-Common-IEntityDto`3-CreatedBy'></a>
### CreatedBy `property`

##### Summary

Gets the value of the created by

<a name='P-CleanCore-Domain-Common-IEntityDto`3-DeletedAt'></a>
### DeletedAt `property`

##### Summary

Gets the value of the deleted at

<a name='P-CleanCore-Domain-Common-IEntityDto`3-DeletedBy'></a>
### DeletedBy `property`

##### Summary

Gets the value of the deleted by

<a name='P-CleanCore-Domain-Common-IEntityDto`3-Id'></a>
### Id `property`

##### Summary

Gets the value of the id

<a name='P-CleanCore-Domain-Common-IEntityDto`3-LastModifiedAt'></a>
### LastModifiedAt `property`

##### Summary

Gets the value of the last modified at

<a name='P-CleanCore-Domain-Common-IEntityDto`3-LastModifiedBy'></a>
### LastModifiedBy `property`

##### Summary

Gets the value of the last modified by

<a name='M-CleanCore-Domain-Common-IEntityDto`3-ToEntity'></a>
### ToEntity() `method`

##### Summary

Returns the entity

##### Returns

The entity

##### Parameters

This method has no parameters.

<a name='T-CleanCore-Domain-Common-IOrganizationEntity`1'></a>
## IOrganizationEntity\`1 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The organization entity interface

<a name='P-CleanCore-Domain-Common-IOrganizationEntity`1-OrganizationId'></a>
### OrganizationId `property`

##### Summary

Gets or sets the value of the organization id

<a name='T-CleanCore-Domain-Common-IOrganization`1'></a>
## IOrganization\`1 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The organization interface

<a name='P-CleanCore-Domain-Common-IOrganization`1-Id'></a>
### Id `property`

##### Summary

Gets the value of the id

<a name='P-CleanCore-Domain-Common-IOrganization`1-Name'></a>
### Name `property`

##### Summary

Gets the value of the name

<a name='P-CleanCore-Domain-Common-IOrganization`1-UserAccess'></a>
### UserAccess `property`

##### Summary

Gets the value of the user access

<a name='T-CleanCore-Domain-Common-IUser'></a>
## IUser `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The user interface

<a name='P-CleanCore-Domain-Common-IUser-Name'></a>
### Name `property`

##### Summary

Gets the value of the name

<a name='T-CleanCore-Domain-Common-IUserOrganizationAccess'></a>
## IUserOrganizationAccess `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The user organization access interface

<a name='P-CleanCore-Domain-Common-IUserOrganizationAccess-Access'></a>
### Access `property`

##### Summary

Gets the value of the access

<a name='P-CleanCore-Domain-Common-IUserOrganizationAccess-User'></a>
### User `property`

##### Summary

Gets the value of the user

<a name='T-CleanCore-Domain-Common-IUser`1'></a>
## IUser\`1 `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The user interface

##### See Also

- [CleanCore.Domain.Common.IUser](#T-CleanCore-Domain-Common-IUser 'CleanCore.Domain.Common.IUser')

<a name='P-CleanCore-Domain-Common-IUser`1-Sub'></a>
### Sub `property`

##### Summary

Gets the value of the sub

<a name='T-CleanCore-Domain-Common-UserOrganizationAccess'></a>
## UserOrganizationAccess `type`

##### Namespace

CleanCore.Domain.Common

##### Summary

The user organization access enum

<a name='F-CleanCore-Domain-Common-UserOrganizationAccess-Full'></a>
### Full `constants`

##### Summary

The full user organization access

<a name='F-CleanCore-Domain-Common-UserOrganizationAccess-None'></a>
### None `constants`

##### Summary

The none user organization access

<a name='F-CleanCore-Domain-Common-UserOrganizationAccess-Owner'></a>
### Owner `constants`

##### Summary

The owner user organization access

<a name='F-CleanCore-Domain-Common-UserOrganizationAccess-Read'></a>
### Read `constants`

##### Summary

The read user organization access

<a name='F-CleanCore-Domain-Common-UserOrganizationAccess-Write'></a>
### Write `constants`

##### Summary

The write user organization access
