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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
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
		/// <returns>async System.Threading.Tasks.Task<PIItemsChannelInstance></returns>
		System.Threading.Tasks.Task<PIItemsChannelInstance> InstancesAsync();

		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>> InstancesAsyncWithHttpInfo();


		/// <summary>
		/// Retrieves continuous updates about a stream. 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		/// 
		System.Threading.Tasks.Task StartStream(string webId, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken);


		/// <summary>
		/// Retrieves continuous updates about a stream set. 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		/// 
		System.Threading.Tasks.Task StartStreamSet(string webId, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken);
		
		
		/// <summary>
		/// Retrieves continuous updates about multiple streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		/// 
		System.Threading.Tasks.Task StartStreamSets(List<string> webIds, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken);
		
		#endregion
	}

	public class ChannelApi : IChannelApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public ChannelApi(Configuration configuration = null)
		{
			if (configuration == null)
				this.Configuration = Configuration.Default;
			else
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
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("InstancesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsChannelInstance>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
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
		/// <returns>async System.Threading.Tasks.Task<PIItemsChannelInstance></returns>
		public async System.Threading.Tasks.Task<PIItemsChannelInstance> InstancesAsync()
		{
			ApiResponse<PIItemsChannelInstance> localVarResponse = await InstancesAsyncWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieves a list of currently running channel instances.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>> InstancesAsyncWithHttpInfo()
		{

			var localVarPath = "/channels/instances";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
			localVarPathParams.Add("format", "json");

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("InstancesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsChannelInstance>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsChannelInstance)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsChannelInstance)));
		}

		public string ChannelsBaseUrl
		{
			get
			{
				return this.Configuration.ApiClient.RestClient.BaseUrl.ToString().Replace("https", "wss");
			}
		}
		/// <summary>
		/// Retrieves continuous updates about a stream.
		/// </summary>
		/// <remarks>

		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>

		public System.Threading.Tasks.Task StartStream(string webId, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken)
		{
			string url = string.Format(this.ChannelsBaseUrl + "/streams/{0}/channel", webId);
			return RunClient(url, observer, cancellationToken);
		}
		/// <summary>
		/// Retrieves continuous updates about a stream set.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		
		public System.Threading.Tasks.Task StartStreamSet(string webId, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken)
		{
			string url = string.Format(this.ChannelsBaseUrl + "/streamsets/{0}/channel", webId);
			return RunClient(url, observer, cancellationToken);
		}
		
		/// <summary>
		/// Retrieves continuous updates about multiple streams.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsChannelInstance>></returns>
		/// 
		public System.Threading.Tasks.Task StartStreamSets(List<string> webIds, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken)
		{
			string url = this.ChannelsBaseUrl + "/streamsets/channel?";
			foreach (string webId in webIds)
			{
				url = url + string.Format("webId={0}&", webId);
			}
			url = url.Substring(0, url.Length - 1);
			return RunClient(url, observer, cancellationToken);
		}
		
		private async System.Threading.Tasks.Task RunClient(string url, IObserver<PIItemsStreamValues> observer, System.Threading.CancellationToken cancellationToken)
		{
			Uri uri = new Uri(url);
			System.Net.WebSockets.WebSocketReceiveResult receiveResult;
			byte[] receiveBuffer = new byte[65536];
			ArraySegment<byte> receiveSegment = new ArraySegment<byte>(receiveBuffer);
			
			using (System.Net.WebSockets.ClientWebSocket webSocket = new System.Net.WebSockets.ClientWebSocket())
			{
				if ((this.Configuration.Username == null) || (this.Configuration.Password == null))
				{
					webSocket.Options.UseDefaultCredentials = true;
				}
				else
				{
					webSocket.Options.Credentials = new System.Net.NetworkCredential(this.Configuration.Username, this.Configuration.Password);
				}
		
				try
				{
					await webSocket.ConnectAsync(uri, System.Threading.CancellationToken.None);
				}
				catch (System.Net.WebSockets.WebSocketException e)
				{
					Console.WriteLine("Could not connect to server.");
					observer.OnError(e);
					return;
				}
				while (true)
				{
					try
					{
						receiveResult = await webSocket.ReceiveAsync(receiveSegment, cancellationToken);
					}
					catch (OperationCanceledException)
					{
						observer.OnCompleted();
						break;
					}
			
					if (receiveResult.MessageType != System.Net.WebSockets.WebSocketMessageType.Text)
					{
						await webSocket.CloseAsync(
							System.Net.WebSockets.WebSocketCloseStatus.InvalidMessageType,
							"Message type is not text.",
							System.Threading.CancellationToken.None);
						observer.OnError(new Exception("Message type is not text."));
						return;
					}
					else if (receiveResult.Count > receiveBuffer.Length)
					{
			
						await webSocket.CloseAsync(
							System.Net.WebSockets.WebSocketCloseStatus.InvalidPayloadData,
							"Message is too long.",
							System.Threading.CancellationToken.None);
						observer.OnError(new Exception("Message is too long."));
						return;
					}
					try
					{
						string message = System.Text.Encoding.UTF8.GetString(receiveBuffer, 0, receiveResult.Count);
						PIItemsStreamValues values = Newtonsoft.Json.JsonConvert.DeserializeObject<PIItemsStreamValues>(message);
						observer.OnNext(values);
					}
					catch (Exception e)
					{
					observer.OnError(e);
					}
				}
				await webSocket.CloseAsync(
				System.Net.WebSockets.WebSocketCloseStatus.NormalClosure,
				"Closing connection.",
					System.Threading.CancellationToken.None);
					observer.OnCompleted();
			}
		}
		#endregion
	}
}
