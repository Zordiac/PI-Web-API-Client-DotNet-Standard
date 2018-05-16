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
	/// PIPoint
	/// </summary>
	[DataContract]

	public class PIPoint
	{
		public PIPoint(string WebId = null, int? Id = null, string Name = null, string Path = null, string Descriptor = null, string PointClass = null, string PointType = null, string DigitalSetName = null, double? Span = null, double? Zero = null, string EngineeringUnits = null, bool? Step = null, bool? Future = null, int? DisplayDigits = null, PIPointLinks Links = null, PIWebException WebException = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Path = Path;
			this.Descriptor = Descriptor;
			this.PointClass = PointClass;
			this.PointType = PointType;
			this.DigitalSetName = DigitalSetName;
			this.Span = Span;
			this.Zero = Zero;
			this.EngineeringUnits = EngineeringUnits;
			this.Step = Step;
			this.Future = Future;
			this.DisplayDigits = DisplayDigits;
			this.Links = Links;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public int? Id { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Descriptor", EmitDefaultValue = false)]
		public string Descriptor { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "PointClass", EmitDefaultValue = false)]
		public string PointClass { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "PointType", EmitDefaultValue = false)]
		public string PointType { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "DigitalSetName", EmitDefaultValue = false)]
		public string DigitalSetName { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Span", EmitDefaultValue = false)]
		public double? Span { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Zero", EmitDefaultValue = false)]
		public double? Zero { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "EngineeringUnits", EmitDefaultValue = false)]
		public string EngineeringUnits { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Step", EmitDefaultValue = false)]
		public bool? Step { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Future", EmitDefaultValue = false)]
		public bool? Future { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "DisplayDigits", EmitDefaultValue = false)]
		public int? DisplayDigits { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIPointLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets PIPoint
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
