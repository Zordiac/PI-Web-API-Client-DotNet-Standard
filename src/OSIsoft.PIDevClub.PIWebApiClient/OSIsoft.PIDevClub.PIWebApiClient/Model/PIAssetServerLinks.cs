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
	/// PIAssetServerLinks
	/// </summary>
	[DataContract]

	public class PIAssetServerLinks
	{
		public PIAssetServerLinks(string Self = null, string Databases = null, string NotificationContactTemplates = null, string SecurityIdentities = null, string SecurityMappings = null, string UnitClasses = null, string AnalysisRulePlugIns = null, string TimeRulePlugIns = null, string Security = null, string SecurityEntries = null)
		{
			this.Self = Self;
			this.Databases = Databases;
			this.NotificationContactTemplates = NotificationContactTemplates;
			this.SecurityIdentities = SecurityIdentities;
			this.SecurityMappings = SecurityMappings;
			this.UnitClasses = UnitClasses;
			this.AnalysisRulePlugIns = AnalysisRulePlugIns;
			this.TimeRulePlugIns = TimeRulePlugIns;
			this.Security = Security;
			this.SecurityEntries = SecurityEntries;
		}

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "Databases", EmitDefaultValue = false)]
		public string Databases { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "NotificationContactTemplates", EmitDefaultValue = false)]
		public string NotificationContactTemplates { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "SecurityIdentities", EmitDefaultValue = false)]
		public string SecurityIdentities { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "SecurityMappings", EmitDefaultValue = false)]
		public string SecurityMappings { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "UnitClasses", EmitDefaultValue = false)]
		public string UnitClasses { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "AnalysisRulePlugIns", EmitDefaultValue = false)]
		public string AnalysisRulePlugIns { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "TimeRulePlugIns", EmitDefaultValue = false)]
		public string TimeRulePlugIns { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		/// <summary>
		/// Gets or Sets PIAssetServerLinks
		/// </summary>
		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
