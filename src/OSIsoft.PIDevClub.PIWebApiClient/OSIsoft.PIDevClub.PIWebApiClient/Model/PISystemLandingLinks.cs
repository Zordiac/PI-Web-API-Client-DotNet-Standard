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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using System.Runtime.InteropServices;

namespace OSIsoft.PIDevClub.PIWebApiClient.Model
{

	/// <summary>
	/// PISystemLandingLinks
	/// </summary>
	[DataContract]

	public class PISystemLandingLinks
	{
		public PISystemLandingLinks(string Self = null, string CacheInstances = null, string Configuration = null, string UserInfo = null, string Versions = null, string Status = null)
		{
			this.Self = Self;
			this.CacheInstances = CacheInstances;
			this.Configuration = Configuration;
			this.UserInfo = UserInfo;
			this.Versions = Versions;
			this.Status = Status;
		}

		/// <summary>
		/// Gets or Sets PISystemLandingLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PISystemLandingLinks
		/// </summary>
		[DataMember(Name = "CacheInstances", EmitDefaultValue = false)]
		public string CacheInstances { get; set; }

		/// <summary>
		/// Gets or Sets PISystemLandingLinks
		/// </summary>
		[DataMember(Name = "Configuration", EmitDefaultValue = false)]
		public string Configuration { get; set; }

		/// <summary>
		/// Gets or Sets PISystemLandingLinks
		/// </summary>
		[DataMember(Name = "UserInfo", EmitDefaultValue = false)]
		public string UserInfo { get; set; }

		/// <summary>
		/// Gets or Sets PISystemLandingLinks
		/// </summary>
		[DataMember(Name = "Versions", EmitDefaultValue = false)]
		public string Versions { get; set; }

		/// <summary>
		/// Gets or Sets PISystemLandingLinks
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

	}
}
