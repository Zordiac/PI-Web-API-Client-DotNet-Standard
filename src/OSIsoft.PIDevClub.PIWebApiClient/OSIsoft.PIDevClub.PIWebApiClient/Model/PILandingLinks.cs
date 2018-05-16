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
	/// PILandingLinks
	/// </summary>
	[DataContract]

	public class PILandingLinks
	{
		public PILandingLinks(string Self = null, string AssetServers = null, string DataServers = null, string PIDirectory = null, string Search = null, string System = null)
		{
			this.Self = Self;
			this.AssetServers = AssetServers;
			this.DataServers = DataServers;
			this.PIDirectory = PIDirectory;
			this.Search = Search;
			this.System = System;
		}

		/// <summary>
		/// Gets or Sets PILandingLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PILandingLinks
		/// </summary>
		[DataMember(Name = "AssetServers", EmitDefaultValue = false)]
		public string AssetServers { get; set; }

		/// <summary>
		/// Gets or Sets PILandingLinks
		/// </summary>
		[DataMember(Name = "DataServers", EmitDefaultValue = false)]
		public string DataServers { get; set; }

		/// <summary>
		/// Gets or Sets PILandingLinks
		/// </summary>
		[DataMember(Name = "PIDirectory", EmitDefaultValue = false)]
		public string PIDirectory { get; set; }

		/// <summary>
		/// Gets or Sets PILandingLinks
		/// </summary>
		[DataMember(Name = "Search", EmitDefaultValue = false)]
		public string Search { get; set; }

		/// <summary>
		/// Gets or Sets PILandingLinks
		/// </summary>
		[DataMember(Name = "System", EmitDefaultValue = false)]
		public string System { get; set; }

	}
}
