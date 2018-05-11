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
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace OSIsoft.PIDevClub.PIWebApiClient.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        public Configuration(ApiClient client)
        {
            this.ApiClient = client;
            DefaultHeader = new Dictionary<string, string>();
        }

        public IDictionary<string, string> DefaultHeader { get; set; }
        public ApiClient ApiClient { get; private set; }
        public Configuration Default { get; internal set; }

        internal static Exception DefaultExceptionFactory(string methodName, IRestResponse response)
        {
            int status = (int)response.StatusCode;
            if (status >= 400) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.StringContent), response.JsonContent);
            if (status == 0) return new ApiException(status, String.Format("Error calling {0}: {1}", methodName, response.StringContent), response.JsonContent);
            return null;
        }
    }
}
