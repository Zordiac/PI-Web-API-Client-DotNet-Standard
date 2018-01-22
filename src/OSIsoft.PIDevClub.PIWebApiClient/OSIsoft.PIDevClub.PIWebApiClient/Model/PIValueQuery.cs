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
using System.ComponentModel.DataAnnotations;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using System.Runtime.InteropServices;

namespace OSIsoft.PIDevClub.PIWebApiClient.Model
{

	/// <summary>
	/// PIValueQuery
	/// </summary>
	[DataContract]

	public class PIValueQuery
	{
		public PIValueQuery(string AttributeName = null, string AttributeUOM = null, object AttributeValue = null, string SearchOperator = null, PIWebException WebException = null)
		{
			this.AttributeName = AttributeName;
			this.AttributeUOM = AttributeUOM;
			this.AttributeValue = AttributeValue;
			this.SearchOperator = SearchOperator;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PIValueQuery
		/// </summary>
		[DataMember(Name = "AttributeName", EmitDefaultValue = false)]
		public string AttributeName { get; set; }

		/// <summary>
		/// Gets or Sets PIValueQuery
		/// </summary>
		[DataMember(Name = "AttributeUOM", EmitDefaultValue = false)]
		public string AttributeUOM { get; set; }

		/// <summary>
		/// Gets or Sets PIValueQuery
		/// </summary>
		[DataMember(Name = "AttributeValue", EmitDefaultValue = false)]
		public object AttributeValue { get; set; }

		/// <summary>
		/// Gets or Sets PIValueQuery
		/// </summary>
		[DataMember(Name = "SearchOperator", EmitDefaultValue = false)]
		public string SearchOperator { get; set; }

		/// <summary>
		/// Gets or Sets PIValueQuery
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
