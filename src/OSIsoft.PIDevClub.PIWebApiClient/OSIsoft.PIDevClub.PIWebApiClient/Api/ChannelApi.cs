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
	/// Represents a collection of functions to interact with the PI Web API Channel controller.
	/// </summary>
	public interface IChannelApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PIItemsChannelInstance</returns>
		PIItemsChannelInstance Instances();

		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PIItemsChannelInstance></returns>
		ApiResponse<PIItemsChannelInstance> InstancesWithHttpInfo();

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsChannelInstance></returns>
		System.Threading.Tasks.Task<PIItemsChannelInstance> InstancesAsync(CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>> InstancesAsyncWithHttpInfo(CancellationTokenSource cancellationTokenSource = null);

		#endregion
	}

	public class ChannelApi : IChannelApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public ChannelApi(Configuration configuration = null)
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
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PIItemsChannelInstance</returns>
		public PIItemsChannelInstance Instances()
		{
			ApiResponse<PIItemsChannelInstance> localVarResponse = InstancesWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PIItemsChannelInstance></returns>
		public ApiResponse<PIItemsChannelInstance> InstancesWithHttpInfo()
		{

			var localVarPath = "/channels/instances";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("InstancesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsChannelInstance>(localVarStatusCode,
				(PIItemsChannelInstance)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsChannelInstance)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsChannelInstance></returns>
		public async System.Threading.Tasks.Task<PIItemsChannelInstance> InstancesAsync(CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PIItemsChannelInstance> localVarResponse = await InstancesAsyncWithHttpInfo(cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>> InstancesAsyncWithHttpInfo(CancellationTokenSource cancellationTokenSource = null)
		{

			var localVarPath = "/channels/instances";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("InstancesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsChannelInstance>(localVarStatusCode,
				(PIItemsChannelInstance)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsChannelInstance)));
		}

		#endregion
	}
}
