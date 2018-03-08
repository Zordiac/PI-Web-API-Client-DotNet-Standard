# WebIdHelper

Method | Description
------------ | -------------
[**GetWebIdInfo**](WebIdHelper.md#getwebidinfo) | Get WebID 2.0 information.
[**GenerateWebIdByPath**](WebIdHelper.md#generatewebidbypath) | Generate a WebID client-side using the object's path.


# **GetWebIdInfo**
> WebIdInfo GetWebIdInfo(string webId)

Get WebID 2.0 information.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the PIObject.. | [required]

### Return type

[**WebIdInfo**](../Model/WebIdInfo.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GenerateWebIdByPath**
> string GenerateWebIdByPath(string path, Type type, Type ownerType = null);

Generate a WebID client-side using the object's path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string** | The path of the PIObject. | [required]
 **type** | **Type** | The type of the PIObject. | [required]
 **ownerType** | **Type** | Optional parameter.  The type of the owner of the PIObject. It is required for some types of objects | [optional]


### Return type String


[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
