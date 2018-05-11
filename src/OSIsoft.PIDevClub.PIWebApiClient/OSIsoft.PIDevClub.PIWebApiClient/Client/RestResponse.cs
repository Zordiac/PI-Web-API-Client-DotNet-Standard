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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OSIsoft.PIDevClub.PIWebApiClient.Client
{
    internal class RestResponse : IRestResponse
    {
        private HttpResponseMessage response;

        public RestResponse()
        {
        }

        public RestResponse(HttpResponseMessage response)
        {
            this.response = response;
            Stream stream = response.Content.ReadAsStreamAsync().Result;
            StreamReader streamReader = new StreamReader(stream);
            StringContent = streamReader.ReadToEndAsync().Result;
            JsonContent = JsonConvert.DeserializeObject<dynamic>(this.StringContent);
        }
        public bool IsSuccessful => response.IsSuccessStatusCode;
        public HttpStatusCode StatusCode { get => response.StatusCode; }
        public HttpContent Content { get => response.Content; }
        public string StatusDescription { get => response.ReasonPhrase; }
        public Version ProtocolVersion { get => response.Version; }
        public HttpResponseHeaders Headers { get => response.Headers; }
        public string StringContent { get; }
        public dynamic JsonContent { get; }
    }
}