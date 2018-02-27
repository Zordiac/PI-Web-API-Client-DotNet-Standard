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
	/// PIDataServerLicense
	/// </summary>
	[DataContract]

	public class PIDataServerLicense
	{
		public PIDataServerLicense(string AmountLeft = null, string AmountUsed = null, string Name = null, string TotalAmount = null, PIDataServerLicenseLinks Links = null, PIWebException WebException = null)
		{
			this.AmountLeft = AmountLeft;
			this.AmountUsed = AmountUsed;
			this.Name = Name;
			this.TotalAmount = TotalAmount;
			this.Links = Links;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PIDataServerLicense
		/// </summary>
		[DataMember(Name = "AmountLeft", EmitDefaultValue = false)]
		public string AmountLeft { get; set; }

		/// <summary>
		/// Gets or Sets PIDataServerLicense
		/// </summary>
		[DataMember(Name = "AmountUsed", EmitDefaultValue = false)]
		public string AmountUsed { get; set; }

		/// <summary>
		/// Gets or Sets PIDataServerLicense
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIDataServerLicense
		/// </summary>
		[DataMember(Name = "TotalAmount", EmitDefaultValue = false)]
		public string TotalAmount { get; set; }

		/// <summary>
		/// Gets or Sets PIDataServerLicense
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIDataServerLicenseLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets PIDataServerLicense
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
