# NotificationRuleApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetNotificationRules**](NotificationRuleApi.md#getnotificationrules) | **GET** /notificationrules/{webId} | Retrieve a notification rule.
[**GetNotificationRuleSubscribers**](NotificationRuleApi.md#getnotificationrulesubscribers) | **GET** /notificationrules/{webId}/notificationrulesubscribers | Retrieve notification rule subscribers.
[**GetNotificationRulesQuery**](NotificationRuleApi.md#getnotificationrulesquery) | **GET** /notificationrules/search | Retrieve notification rules based on the specified conditions. Returns notification rules using the specified search query string.


# **GetNotificationRules**
> GetNotificationRules(string webId, string selectedFields = null, string webIdType = null)

Retrieve a notification rule.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PINotificationRule**](../Model/PINotificationRule.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetNotificationRuleSubscribers**
> GetNotificationRuleSubscribers(string webId, string selectedFields = null, string webIdType = null)

Retrieve notification rule subscribers.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsNotificationRuleSubscriber**](../Model/PIItemsNotificationRuleSubscriber.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetNotificationRulesQuery**
> GetNotificationRulesQuery(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null)

Retrieve notification rules based on the specified conditions. Returns notification rules using the specified search query string.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **databaseWebId** | **string**| The ID of the asset database to use as the root of the query.. | [optional]
 **maxCount** | **int?**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [optional]
 **query** | **string**| The query string is a list of filters used to perform an AFSearch for the Notification rules in the asset database. An example would be: "query=Name:=MyNotificationRule* Template:=NoteRuleTemplate*".. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startIndex** | **int?**| The starting index (zero based) of the items to be returned. The default is 0.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsNotificationRule**](../Model/PIItemsNotificationRule.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
