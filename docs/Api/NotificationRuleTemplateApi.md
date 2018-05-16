# NotificationRuleTemplateApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**Get**](NotificationRuleTemplateApi.md#get) | **GET** /notificationruletemplates/{webId} | Get the specified notification rule template.
[**GetNotificationRuleTemplateSubscribers**](NotificationRuleTemplateApi.md#getnotificationruletemplatesubscribers) | **GET** /notificationruletemplates/{webId}/notificationrulesubscribers | Retrieve notification rule template subscribers.
[**GetNotificationRuleTemplatesQuery**](NotificationRuleTemplateApi.md#getnotificationruletemplatesquery) | **GET** /notificationruletemplates/search | Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.


# **Get**
> Get(string webId, string selectedFields = null, string webIdType = null)

Get the specified notification rule template.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the notification rule template.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PINotificationRuleTemplate**](../Model/PINotificationRuleTemplate.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetNotificationRuleTemplateSubscribers**
> GetNotificationRuleTemplateSubscribers(string webId, string selectedFields = null, string webIdType = null)

Retrieve notification rule template subscribers.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsNotificationRuleSubscriber**](../Model/PIItemsNotificationRuleSubscriber.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetNotificationRuleTemplatesQuery**
> GetNotificationRuleTemplatesQuery(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null)

Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **databaseWebId** | **string**| The ID of the asset database to use as the root of the query.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **query** | **string**| The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsNotificationRuleTemplate**](../Model/PIItemsNotificationRuleTemplate.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
