# NotificationContactTemplateApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**Get**](NotificationContactTemplateApi.md#get) | **GET** /notificationcontacttemplates/{webId} | Retrieve a notification contact template.


# **Get**
> Get(string webId, string selectedFields = null, string webIdType = null)

Retrieve a notification contact template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the notification contact template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PINotificationContactTemplate**](../Model/PINotificationContactTemplate.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
