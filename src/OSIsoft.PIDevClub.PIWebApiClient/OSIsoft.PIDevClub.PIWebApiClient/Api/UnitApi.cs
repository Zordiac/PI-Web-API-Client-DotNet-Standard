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
	/// Represents a collection of functions to interact with the PI Web API Unit controller.
	/// </summary>
	public interface IUnitApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIUnit</returns>
		PIUnit GetByPath(string path, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIUnit></returns>
		ApiResponse<PIUnit> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIUnit</returns>
		PIUnit Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIUnit></returns>
		ApiResponse<PIUnit> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <returns>Object</returns>
		Object Update(string webId, PIUnit unitDTO);

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateWithHttpInfo(string webId, PIUnit unitDTO);

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <returns>Object</returns>
		Object Delete(string webId);

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteWithHttpInfo(string webId);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIUnit></returns>
		System.Threading.Tasks.Task<PIUnit> GetByPathAsync(string path, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null);

		/// <summary>
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIUnit>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIUnit>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null);

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIUnit></returns>
		System.Threading.Tasks.Task<PIUnit> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null);

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIUnit>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIUnit>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null);

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIUnit unitDTO, CancellationToken? cancellationToken = null);

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIUnit unitDTO, CancellationToken? cancellationToken = null);

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteAsync(string webId, CancellationToken? cancellationToken = null);

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId, CancellationToken? cancellationToken = null);

		#endregion
	}

	public class UnitApi : IUnitApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public UnitApi(Configuration configuration = null)
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
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIUnit</returns>
		public PIUnit GetByPath(string path, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIUnit> localVarResponse = GetByPathWithHttpInfo(path, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIUnit></returns>
		public ApiResponse<PIUnit> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/units";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (path!= null) localVarQueryParams.Add("path", path, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIUnit>(localVarStatusCode,
				localVarResponse.Headers,
				(PIUnit)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIUnit)));
		}

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIUnit</returns>
		public PIUnit Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIUnit> localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIUnit></returns>
		public ApiResponse<PIUnit> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/units/{webId}";
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

			return new ApiResponse<PIUnit>(localVarStatusCode,
				localVarResponse.Headers,
				(PIUnit)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIUnit)));
		}

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <returns>Object</returns>
		public Object Update(string webId, PIUnit unitDTO)
		{
			ApiResponse<Object> localVarResponse = UpdateWithHttpInfo(webId, unitDTO);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateWithHttpInfo(string webId, PIUnit unitDTO)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'unitDTO' is set
			if (unitDTO == null)
				throw new ApiException(400, "Missing required parameter 'unitDTO'");

			var localVarPath = "/units/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(unitDTO);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("PATCH"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <returns>Object</returns>
		public Object Delete(string webId)
		{
			ApiResponse<Object> localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteWithHttpInfo(string webId)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/units/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIUnit></returns>
		public async System.Threading.Tasks.Task<PIUnit> GetByPathAsync(string path, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null)
		{
			ApiResponse<PIUnit> localVarResponse = await GetByPathAsyncWithHttpInfo(path, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a unit by path.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIUnit>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIUnit>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/units";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (path!= null) localVarQueryParams.Add("path", path, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIUnit>(localVarStatusCode,
				localVarResponse.Headers,
				(PIUnit)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIUnit)));
		}

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIUnit></returns>
		public async System.Threading.Tasks.Task<PIUnit> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null)
		{
			ApiResponse<PIUnit> localVarResponse = await GetAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIUnit>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIUnit>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken? cancellationToken = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/units/{webId}";
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
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIUnit>(localVarStatusCode,
				localVarResponse.Headers,
				(PIUnit)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIUnit)));
		}

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateAsync(string webId, PIUnit unitDTO, CancellationToken? cancellationToken = null)
		{
			ApiResponse<Object> localVarResponse = await UpdateAsyncWithHttpInfo(webId, unitDTO, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="unitDTO">A partial unit containing the desired changes.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateAsyncWithHttpInfo(string webId, PIUnit unitDTO, CancellationToken? cancellationToken = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'unitDTO' is set
			if (unitDTO == null)
				throw new ApiException(400, "Missing required parameter 'unitDTO'");

			var localVarPath = "/units/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(unitDTO);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("PATCH"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteAsync(string webId, CancellationToken? cancellationToken = null)
		{
			ApiResponse<Object> localVarResponse = await DeleteAsyncWithHttpInfo(webId, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a unit.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the unit.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string webId, CancellationToken? cancellationToken = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/units/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
	}
}
