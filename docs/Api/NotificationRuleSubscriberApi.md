# NotificationRuleSubscriberApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetNotificationRuleSubscriberByPath**](NotificationRuleSubscriberApi.md#getnotificationrulesubscriberbypath) | **GET** /notificationrulesubscribers | Retrieve a notification rule subscriber by path.
[**GetNotificationRuleSubscriber**](NotificationRuleSubscriberApi.md#getnotificationrulesubscriber) | **GET** /notificationrulesubscribers/{webId} | Retrieve a notification rule subscriber.
[**GetNotificationRuleSubscribers**](NotificationRuleSubscriberApi.md#getnotificationrulesubscribers) | **GET** /notificationrulesubscribers/{webId}/notificationrulesubscribers | Retrieve notification rule subscriber subscribers.


# **GetNotificationRuleSubscriberByPath**
> GetNotificationRuleSubscriberByPath(string path, string selectedFields = null, string webIdType = null)

Retrieve a notification rule subscriber by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the notification rule subscriber.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PINotificationRuleSubscriber**](../Model/PINotificationRuleSubscriber.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetNotificationRuleSubscriber**
> GetNotificationRuleSubscriber(string webId, string selectedFields = null, string webIdType = null)

Retrieve a notification rule subscriber.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PINotificationRuleSubscriber**](../Model/PINotificationRuleSubscriber.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetNotificationRuleSubscribers**
> GetNotificationRuleSubscribers(string webId, string selectedFields = null, string webIdType = null)

Retrieve notification rule subscriber subscribers.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsNotificationRuleSubscriber**](../Model/PIItemsNotificationRuleSubscriber.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
