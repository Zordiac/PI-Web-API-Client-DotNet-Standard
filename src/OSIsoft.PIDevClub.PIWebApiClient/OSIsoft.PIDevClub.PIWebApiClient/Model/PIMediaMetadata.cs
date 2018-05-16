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
	/// PIMediaMetadata
	/// </summary>
	[DataContract]

	public class PIMediaMetadata
	{
		public PIMediaMetadata(string Author = null, string ChangeDate = null, string Description = null, string Name = null, double? Size = null, PIMediaMetadataLinks Links = null, PIWebException WebException = null)
		{
			this.Author = Author;
			this.ChangeDate = ChangeDate;
			this.Description = Description;
			this.Name = Name;
			this.Size = Size;
			this.Links = Links;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PIMediaMetadata
		/// </summary>
		[DataMember(Name = "Author", EmitDefaultValue = false)]
		public string Author { get; set; }

		/// <summary>
		/// Gets or Sets PIMediaMetadata
		/// </summary>
		[DataMember(Name = "ChangeDate", EmitDefaultValue = false)]
		public string ChangeDate { get; set; }

		/// <summary>
		/// Gets or Sets PIMediaMetadata
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PIMediaMetadata
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIMediaMetadata
		/// </summary>
		[DataMember(Name = "Size", EmitDefaultValue = false)]
		public double? Size { get; set; }

		/// <summary>
		/// Gets or Sets PIMediaMetadata
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIMediaMetadataLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets PIMediaMetadata
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
