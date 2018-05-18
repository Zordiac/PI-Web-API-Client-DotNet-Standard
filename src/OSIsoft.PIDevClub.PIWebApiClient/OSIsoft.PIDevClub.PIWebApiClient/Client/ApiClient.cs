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

using Newtonsoft.Json;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace OSIsoft.PIDevClub.PIWebApiClient.Client
{

    public class ApiClient
    {
        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        public Configuration Configuration { get; internal set; }
        public string BaseUrl { get; private set; }

        private string username;
        private string password;
        private bool useKerberos;
        private HttpClientHandler handler = null;

        public ApiClient(string baseUrl, bool useKerberos, string username, string password)
        {
            this.BaseUrl = baseUrl;
            this.username = username;
            this.password = password;
            this.useKerberos = useKerberos;
            handler = new HttpClientHandler();
            if (useKerberos == true)
            {
                handler.UseDefaultCredentials = true;
            }
        }


        internal string ParameterToString(object obj)
        {
            if (obj is IList)
            {
                var flattenedString = new StringBuilder();
                foreach (var param in (IList)obj)
                {
                    if (flattenedString.Length > 0)
                        flattenedString.Append(",");
                    flattenedString.Append(param);
                }
                return flattenedString.ToString();
            }
            else
            {
                return Convert.ToString(obj);
            }
        }

        internal string Serialize(object Object)
        {
            try
            {
                return JsonConvert.SerializeObject(Object);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }

        }

        internal object Deserialize(IRestResponse localVarResponse, Type type)
        {
            try
            {
                return JsonConvert.DeserializeObject(localVarResponse.StringContent, type, serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        internal IRestResponse CallApi(string localVarPath, HttpMethod method, CustomDictionaryForQueryString localVarQueryParams,
            string localVarPostBody, Dictionary<string, string> localVarHeaderParams, Dictionary<string, string> localVarPathParams)
        {
            HttpRequestMessage request = PrepareRequest(localVarPath, method, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarPathParams);
            HttpClient client = new HttpClient(handler);
            if (this.useKerberos == false)
            {
                var byteArray = Encoding.ASCII.GetBytes(string.Format("{0}:{1}", this.username, this.password));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            }
            HttpResponseMessage response = client.SendAsync(request).Result;
            IRestResponse restResponse = new RestResponse(response);
            return restResponse;
        }

        private HttpRequestMessage PrepareRequest(string localVarPath, HttpMethod method, CustomDictionaryForQueryString localVarQueryParams, string localVarPostBody, Dictionary<string, string> localVarHeaderParams, Dictionary<string, string> localVarPathParams)
        {
            foreach (var param in localVarPathParams)
            {
                localVarPath = localVarPath.Replace("{" + param.Key + "}", param.Value);
            }
            string requestUri = string.Format("{0}{1}", this.BaseUrl, localVarPath);

            if ((localVarQueryParams != null) && (localVarQueryParams.Count > 0))
            {
                string queryString = string.Empty;
                foreach (var query in localVarQueryParams)
                {
                    queryString += string.Format("{0}={1}&", query.Key, HttpUtility.UrlEncode(query.Value));
                }
                requestUri = string.Format("{0}?{1}", requestUri, queryString.Substring(0, queryString.Length - 1));
            }
            HttpRequestMessage request = new HttpRequestMessage(method, requestUri);
            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            foreach (var item in localVarHeaderParams)
            {
                request.Headers.Add(item.Key, item.Value);
            }

            if ((method != HttpMethod.Get) && (method != HttpMethod.Delete) && string.IsNullOrEmpty(localVarPostBody) == false)
            {
                request.Content = new StringContent(localVarPostBody, Encoding.UTF8, "application/json");
            }
            return request;
        }

        internal async Task<IRestResponse> CallApiAsync(string localVarPath, HttpMethod method, CustomDictionaryForQueryString localVarQueryParams,
            string localVarPostBody, Dictionary<string, string> localVarHeaderParams, Dictionary<string, string> localVarPathParams,
            CancellationToken cancellationToken)
        {
            HttpRequestMessage request = PrepareRequest(localVarPath, method, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarPathParams);
            HttpResponseMessage response = null;
            HttpClient client = new HttpClient(handler);

            
            try
            {
                if (cancellationToken == CancellationToken.None)
                {
                    response = await client.SendAsync(request);
                }
                else
                {
                    response = await client.SendAsync(request, cancellationToken);
                }

            }
            catch (TaskCanceledException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new ApiException(1, e.Message);
            }

            IRestResponse restResponse = new RestResponse(response);
            return restResponse;
        }
    }
}
