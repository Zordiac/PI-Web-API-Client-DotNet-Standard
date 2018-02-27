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
	/// PIAttributeLinks
	/// </summary>
	[DataContract]

	public class PIAttributeLinks
	{
		public PIAttributeLinks(string Self = null, string Attributes = null, string Element = null, string EventFrame = null, string Parent = null, string Template = null, string InterpolatedData = null, string RecordedData = null, string PlotData = null, string SummaryData = null, string Value = null, string EndValue = null, string Point = null, string Categories = null, string EnumerationSet = null, string EnumerationValues = null, string Trait = null)
		{
			this.Self = Self;
			this.Attributes = Attributes;
			this.Element = Element;
			this.EventFrame = EventFrame;
			this.Parent = Parent;
			this.Template = Template;
			this.InterpolatedData = InterpolatedData;
			this.RecordedData = RecordedData;
			this.PlotData = PlotData;
			this.SummaryData = SummaryData;
			this.Value = Value;
			this.EndValue = EndValue;
			this.Point = Point;
			this.Categories = Categories;
			this.EnumerationSet = EnumerationSet;
			this.EnumerationValues = EnumerationValues;
			this.Trait = Trait;
		}

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public string Attributes { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Element", EmitDefaultValue = false)]
		public string Element { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "EventFrame", EmitDefaultValue = false)]
		public string EventFrame { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Template", EmitDefaultValue = false)]
		public string Template { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "InterpolatedData", EmitDefaultValue = false)]
		public string InterpolatedData { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "RecordedData", EmitDefaultValue = false)]
		public string RecordedData { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "PlotData", EmitDefaultValue = false)]
		public string PlotData { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "SummaryData", EmitDefaultValue = false)]
		public string SummaryData { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public string Value { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "EndValue", EmitDefaultValue = false)]
		public string EndValue { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Point", EmitDefaultValue = false)]
		public string Point { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "EnumerationSet", EmitDefaultValue = false)]
		public string EnumerationSet { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "EnumerationValues", EmitDefaultValue = false)]
		public string EnumerationValues { get; set; }

		/// <summary>
		/// Gets or Sets PIAttributeLinks
		/// </summary>
		[DataMember(Name = "Trait", EmitDefaultValue = false)]
		public string Trait { get; set; }

	}
}
