# ChannelApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**Instances**](ChannelApi.md#instances) | **GET** /channels/instances | Retrieves a list of currently running channel instances.
[**StartStream**](ChannelApi.md#startstream) | WebSocket | Retrieves continuous updates about a stream.
[**StartStreamSet**](ChannelApi.md#startstreamset) | WebSocket | Retrieves continuous updates about a stream set.
[**StartStreamSets**](ChannelApi.md#startstreamsets) | WebSocket | Retrieves continuous updates about multiple stream sets.


# **Instances**
> Instances()

Retrieves a list of currently running channel instances.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**PIItemsChannelInstance**](../Model/PIItemsChannelInstance.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)


# **StartStream**
> Task StartStream(string webId, IObserver < PIItemsStreamValues > observer, System.Threading.CancellationToken cancellationToken)

Retrieves continuous updates about a stream.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
**webId** | **string** | The ID of the stream. | [required]
**observer** | **IObserver<PIItemsStreamValues>**| Custom class implementing the IObserver<PIItemsStreamValues> interface which will consume the new events. | [required]
**cancellationToken** | **CancellationToken**| CancellationToken used to cancel the execution of the task. | [required]

### Return type System.Threading.Tasks.Task

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **StartStreamSet**
> Task StartStreamSet(string webId, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken)

Retrieves continuous updates about a stream set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
**webId** | **string** | The ID of the stream. | [required]
**observer** | **IObserver<PIItemsStreamValues>**| Custom class implementing the IObserver<PIItemsStreamValues> interface which will consume the new events. | [required]
**cancellationToken** | **CancellationToken**| CancellationToken used to cancel the execution of the task. | [required]

### Return type System.Threading.Tasks.Task


[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)


# **StartStreamSets**
> Task StartStreamSets(List<string> webIds, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken)

Retrieves continuous updates about multiple streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
**webId** | **string** | The ID of the stream. | [required]
**observer** | **IObserver<PIItemsStreamValues>**| Custom class implementing the IObserver<PIItemsStreamValues> interface which will consume the new events. | [required]
**cancellationToken** | **CancellationToken**| CancellationToken used to cancel the execution of the task. | [required]

### Return type System.Threading.Tasks.Task


[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
