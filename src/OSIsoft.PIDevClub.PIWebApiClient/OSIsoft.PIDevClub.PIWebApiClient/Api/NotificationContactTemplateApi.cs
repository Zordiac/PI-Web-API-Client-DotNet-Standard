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
	/// Represents a collection of functions to interact with the PI Web API NotificationContactTemplate controller.
	/// </summary>
	public interface INotificationContactTemplateApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PINotificationContactTemplate</returns>
		PINotificationContactTemplate Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PINotificationContactTemplate></returns>
		ApiResponse<PINotificationContactTemplate> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PINotificationContactTemplate></returns>
		System.Threading.Tasks.Task<PINotificationContactTemplate> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PINotificationContactTemplate>></returns>
		System.Threading.Tasks.Task<ApiResponse<PINotificationContactTemplate>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null);

		#endregion
	}

	public class NotificationContactTemplateApi : INotificationContactTemplateApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public NotificationContactTemplateApi(Configuration configuration = null)
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
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PINotificationContactTemplate</returns>
		public PINotificationContactTemplate Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PINotificationContactTemplate> localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PINotificationContactTemplate></returns>
		public ApiResponse<PINotificationContactTemplate> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/notificationcontacttemplates/{webId}";
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

			return new ApiResponse<PINotificationContactTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PINotificationContactTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PINotificationContactTemplate)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PINotificationContactTemplate></returns>
		public async System.Threading.Tasks.Task<PINotificationContactTemplate> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PINotificationContactTemplate> localVarResponse = await GetAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a notification contact template.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the notification contact template.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PINotificationContactTemplate>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PINotificationContactTemplate>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationTokenSource cancellationTokenSource = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/notificationcontacttemplates/{webId}";
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

			return new ApiResponse<PINotificationContactTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PINotificationContactTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PINotificationContactTemplate)));
		}

		#endregion
	}
}
