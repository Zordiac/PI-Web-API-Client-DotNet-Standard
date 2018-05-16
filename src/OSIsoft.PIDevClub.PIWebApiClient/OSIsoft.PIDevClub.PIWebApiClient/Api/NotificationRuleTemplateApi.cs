// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Linq;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;

namespace OSIsoft.PIDevClub.PIWebApiClient.Api
{


	/// <summary>
	/// Represents a collection of functions to interact with the PI Web API NotificationRuleTemplate controller.
	/// </summary>
	public interface INotificationRuleTemplateApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PINotificationRuleTemplate</returns>
		PINotificationRuleTemplate Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PINotificationRuleTemplate></returns>
		ApiResponse<PINotificationRuleTemplate> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsNotificationRuleSubscriber</returns>
		PIItemsNotificationRuleSubscriber GetNotificationRuleTemplateSubscribers(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsNotificationRuleSubscriber></returns>
		ApiResponse<PIItemsNotificationRuleSubscriber> GetNotificationRuleTemplateSubscribersWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsNotificationRuleTemplate</returns>
		PIItemsNotificationRuleTemplate GetNotificationRuleTemplatesQuery(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null);

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsNotificationRuleTemplate></returns>
		ApiResponse<PIItemsNotificationRuleTemplate> GetNotificationRuleTemplatesQueryWithHttpInfo(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PINotificationRuleTemplate></returns>
		System.Threading.Tasks.Task<PINotificationRuleTemplate> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PINotificationRuleTemplate>></returns>
		System.Threading.Tasks.Task<ApiResponse<PINotificationRuleTemplate>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsNotificationRuleSubscriber></returns>
		System.Threading.Tasks.Task<PIItemsNotificationRuleSubscriber> GetNotificationRuleTemplateSubscribersAsync(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleSubscriber>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleSubscriber>> GetNotificationRuleTemplateSubscribersAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsNotificationRuleTemplate></returns>
		System.Threading.Tasks.Task<PIItemsNotificationRuleTemplate> GetNotificationRuleTemplatesQueryAsync(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleTemplate>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleTemplate>> GetNotificationRuleTemplatesQueryAsyncWithHttpInfo(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		#endregion
	}

	public class NotificationRuleTemplateApi : INotificationRuleTemplateApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public NotificationRuleTemplateApi(Configuration configuration = null)
		{
			this.Configuration = configuration;
			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		#region Synchronous Operations
		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PINotificationRuleTemplate</returns>
		public PINotificationRuleTemplate Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PINotificationRuleTemplate> localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PINotificationRuleTemplate></returns>
		public ApiResponse<PINotificationRuleTemplate> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/notificationruletemplates/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PINotificationRuleTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PINotificationRuleTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PINotificationRuleTemplate)));
		}

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsNotificationRuleSubscriber</returns>
		public PIItemsNotificationRuleSubscriber GetNotificationRuleTemplateSubscribers(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsNotificationRuleSubscriber> localVarResponse = GetNotificationRuleTemplateSubscribersWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsNotificationRuleSubscriber></returns>
		public ApiResponse<PIItemsNotificationRuleSubscriber> GetNotificationRuleTemplateSubscribersWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/notificationruletemplates/{webId}/notificationrulesubscribers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationRuleTemplateSubscribersWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsNotificationRuleSubscriber>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsNotificationRuleSubscriber)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationRuleSubscriber)));
		}

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsNotificationRuleTemplate</returns>
		public PIItemsNotificationRuleTemplate GetNotificationRuleTemplatesQuery(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null)
		{
			ApiResponse<PIItemsNotificationRuleTemplate> localVarResponse = GetNotificationRuleTemplatesQueryWithHttpInfo(databaseWebId, maxCount, query, selectedFields, startIndex, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsNotificationRuleTemplate></returns>
		public ApiResponse<PIItemsNotificationRuleTemplate> GetNotificationRuleTemplatesQueryWithHttpInfo(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null)
		{

			var localVarPath = "/notificationruletemplates/search";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (databaseWebId!= null) localVarQueryParams.Add("databaseWebId", databaseWebId, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationRuleTemplatesQueryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsNotificationRuleTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsNotificationRuleTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationRuleTemplate)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PINotificationRuleTemplate></returns>
		public async System.Threading.Tasks.Task<PINotificationRuleTemplate> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PINotificationRuleTemplate> localVarResponse = await GetAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the specified notification rule template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification rule template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PINotificationRuleTemplate>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PINotificationRuleTemplate>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/notificationruletemplates/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PINotificationRuleTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PINotificationRuleTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PINotificationRuleTemplate)));
		}

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsNotificationRuleSubscriber></returns>
		public async System.Threading.Tasks.Task<PIItemsNotificationRuleSubscriber> GetNotificationRuleTemplateSubscribersAsync(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PIItemsNotificationRuleSubscriber> localVarResponse = await GetNotificationRuleTemplateSubscribersAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve notification rule template subscribers.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the resource to use as the root of the search.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleSubscriber>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleSubscriber>> GetNotificationRuleTemplateSubscribersAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/notificationruletemplates/{webId}/notificationrulesubscribers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationRuleTemplateSubscribersAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsNotificationRuleSubscriber>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsNotificationRuleSubscriber)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationRuleSubscriber)));
		}

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsNotificationRuleTemplate></returns>
		public async System.Threading.Tasks.Task<PIItemsNotificationRuleTemplate> GetNotificationRuleTemplatesQueryAsync(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PIItemsNotificationRuleTemplate> localVarResponse = await GetNotificationRuleTemplatesQueryAsyncWithHttpInfo(databaseWebId, maxCount, query, selectedFields, startIndex, webIdType, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="databaseWebId">The ID of the asset database to use as the root of the query.</param>
		/// <param name="maxCount">The maximum number of objects to be returned per call (page size). The default is 1000.</param>
		/// <param name="query">The query string is a list of filters used to perform an AFSearch for the Notification rule templates in the asset database. An example would be: "query=NotificationRuleTemplate:{ Name:='MyNotificationRuleTemplate' } Type:=Int32".</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startIndex">The starting index (zero based) of the items to be returned. The default is 0.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleTemplate>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationRuleTemplate>> GetNotificationRuleTemplatesQueryAsyncWithHttpInfo(string databaseWebId = null, int? maxCount = null, string query = null, string selectedFields = null, int? startIndex = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{

			var localVarPath = "/notificationruletemplates/search";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (databaseWebId!= null) localVarQueryParams.Add("databaseWebId", databaseWebId, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startIndex!= null) localVarQueryParams.Add("startIndex", startIndex, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationRuleTemplatesQueryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsNotificationRuleTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsNotificationRuleTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationRuleTemplate)));
		}

		#endregion
	}
}
