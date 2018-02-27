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
	/// PIUnitClassLinks
	/// </summary>
	[DataContract]

	public class PIUnitClassLinks
	{
		public PIUnitClassLinks(string Self = null, string CanonicalUnit = null, string Units = null, string AssetServer = null)
		{
			this.Self = Self;
			this.CanonicalUnit = CanonicalUnit;
			this.Units = Units;
			this.AssetServer = AssetServer;
		}

		/// <summary>
		/// Gets or Sets PIUnitClassLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIUnitClassLinks
		/// </summary>
		[DataMember(Name = "CanonicalUnit", EmitDefaultValue = false)]
		public string CanonicalUnit { get; set; }

		/// <summary>
		/// Gets or Sets PIUnitClassLinks
		/// </summary>
		[DataMember(Name = "Units", EmitDefaultValue = false)]
		public string Units { get; set; }

		/// <summary>
		/// Gets or Sets PIUnitClassLinks
		/// </summary>
		[DataMember(Name = "AssetServer", EmitDefaultValue = false)]
		public string AssetServer { get; set; }

	}
}
