# WebApiHelper

Method | Description
------------ | -------------
[**GetWebIdInfo**](WebApiHelper.md#getwebidinfo) | Get WebID information.
[**GenerateWebIdByPath**](WebApiHelper.md#generatewebidbypath) | Generate a WebID on the client using the Path.



# **GetWebIdInfo**
> WebIdInfo GetWebIdInfo(string webId)

Get Web ID information.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the PIObject.. | [required]

### Return type

[**WebIdInfo**](../Model/WebIdInfo.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GenerateWebIdByPath**
> string GenerateWebIdByPath(string path, Type type, Type ownerType = null);

Get a WebID using a path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string** | The path of the PIObject. | [required]
 **type** | **Type** | The type of the PIObject. | [required]
 **ownerType** | **Type** | Optional parameter.  The type of the owner of the PIObject. It is required for some types of objects | [optional]


### Return type String


[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
