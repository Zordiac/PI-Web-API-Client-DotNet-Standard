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
	/// PIAssetDatabaseLinks
	/// </summary>
	[DataContract]

	public class PIAssetDatabaseLinks
	{
		public PIAssetDatabaseLinks(string Self = null, string Elements = null, string ElementTemplates = null, string EventFrames = null, string AssetServer = null, string ElementCategories = null, string AttributeCategories = null, string TableCategories = null, string AnalysisCategories = null, string AnalysisTemplates = null, string EnumerationSets = null, string Tables = null, string Security = null, string SecurityEntries = null)
		{
			this.Self = Self;
			this.Elements = Elements;
			this.ElementTemplates = ElementTemplates;
			this.EventFrames = EventFrames;
			this.AssetServer = AssetServer;
			this.ElementCategories = ElementCategories;
			this.AttributeCategories = AttributeCategories;
			this.TableCategories = TableCategories;
			this.AnalysisCategories = AnalysisCategories;
			this.AnalysisTemplates = AnalysisTemplates;
			this.EnumerationSets = EnumerationSets;
			this.Tables = Tables;
			this.Security = Security;
			this.SecurityEntries = SecurityEntries;
		}

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "Elements", EmitDefaultValue = false)]
		public string Elements { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "ElementTemplates", EmitDefaultValue = false)]
		public string ElementTemplates { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "EventFrames", EmitDefaultValue = false)]
		public string EventFrames { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "AssetServer", EmitDefaultValue = false)]
		public string AssetServer { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "ElementCategories", EmitDefaultValue = false)]
		public string ElementCategories { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "AttributeCategories", EmitDefaultValue = false)]
		public string AttributeCategories { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "TableCategories", EmitDefaultValue = false)]
		public string TableCategories { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "AnalysisCategories", EmitDefaultValue = false)]
		public string AnalysisCategories { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "AnalysisTemplates", EmitDefaultValue = false)]
		public string AnalysisTemplates { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "EnumerationSets", EmitDefaultValue = false)]
		public string EnumerationSets { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "Tables", EmitDefaultValue = false)]
		public string Tables { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetDatabaseLinks
		/// </summary>
		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
