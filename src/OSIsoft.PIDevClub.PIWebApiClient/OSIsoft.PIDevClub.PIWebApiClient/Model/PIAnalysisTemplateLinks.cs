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
	/// PIAnalysisTemplateLinks
	/// </summary>
	[DataContract]

	public class PIAnalysisTemplateLinks
	{
		public PIAnalysisTemplateLinks(string Self = null, string Database = null, string Categories = null, string AnalysisRule = null, string AnalysisRulePlugIn = null, string TimeRule = null, string TimeRulePlugIn = null, string Target = null, string Security = null, string SecurityEntries = null)
		{
			this.Self = Self;
			this.Database = Database;
			this.Categories = Categories;
			this.AnalysisRule = AnalysisRule;
			this.AnalysisRulePlugIn = AnalysisRulePlugIn;
			this.TimeRule = TimeRule;
			this.TimeRulePlugIn = TimeRulePlugIn;
			this.Target = Target;
			this.Security = Security;
			this.SecurityEntries = SecurityEntries;
		}

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "AnalysisRule", EmitDefaultValue = false)]
		public string AnalysisRule { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "AnalysisRulePlugIn", EmitDefaultValue = false)]
		public string AnalysisRulePlugIn { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "TimeRule", EmitDefaultValue = false)]
		public string TimeRule { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "TimeRulePlugIn", EmitDefaultValue = false)]
		public string TimeRulePlugIn { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "Target", EmitDefaultValue = false)]
		public string Target { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisTemplateLinks
		/// </summary>
		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
