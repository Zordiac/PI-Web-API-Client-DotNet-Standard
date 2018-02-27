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
	/// PIElementLinks
	/// </summary>
	[DataContract]

	public class PIElementLinks
	{
		public PIElementLinks(string Self = null, string Analyses = null, string Attributes = null, string Elements = null, string Database = null, string Parent = null, string Template = null, string Categories = null, string DefaultAttribute = null, string EventFrames = null, string InterpolatedData = null, string RecordedData = null, string PlotData = null, string SummaryData = null, string Value = null, string EndValue = null, string Security = null, string SecurityEntries = null)
		{
			this.Self = Self;
			this.Analyses = Analyses;
			this.Attributes = Attributes;
			this.Elements = Elements;
			this.Database = Database;
			this.Parent = Parent;
			this.Template = Template;
			this.Categories = Categories;
			this.DefaultAttribute = DefaultAttribute;
			this.EventFrames = EventFrames;
			this.InterpolatedData = InterpolatedData;
			this.RecordedData = RecordedData;
			this.PlotData = PlotData;
			this.SummaryData = SummaryData;
			this.Value = Value;
			this.EndValue = EndValue;
			this.Security = Security;
			this.SecurityEntries = SecurityEntries;
		}

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Analyses", EmitDefaultValue = false)]
		public string Analyses { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public string Attributes { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Elements", EmitDefaultValue = false)]
		public string Elements { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Template", EmitDefaultValue = false)]
		public string Template { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "DefaultAttribute", EmitDefaultValue = false)]
		public string DefaultAttribute { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "EventFrames", EmitDefaultValue = false)]
		public string EventFrames { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "InterpolatedData", EmitDefaultValue = false)]
		public string InterpolatedData { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "RecordedData", EmitDefaultValue = false)]
		public string RecordedData { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "PlotData", EmitDefaultValue = false)]
		public string PlotData { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "SummaryData", EmitDefaultValue = false)]
		public string SummaryData { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public string Value { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "EndValue", EmitDefaultValue = false)]
		public string EndValue { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		/// <summary>
		/// Gets or Sets PIElementLinks
		/// </summary>
		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
