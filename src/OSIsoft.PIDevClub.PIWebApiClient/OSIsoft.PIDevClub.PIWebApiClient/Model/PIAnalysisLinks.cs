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
	/// PIAnalysisLinks
	/// </summary>
	[DataContract]

	public class PIAnalysisLinks
	{
		public PIAnalysisLinks(string Self = null, string Target = null, string Database = null, string Categories = null, string Template = null, string AnalysisRule = null, string AnalysisRulePlugIn = null, string TimeRule = null, string TimeRulePlugIn = null, string Security = null, string SecurityEntries = null)
		{
			this.Self = Self;
			this.Target = Target;
			this.Database = Database;
			this.Categories = Categories;
			this.Template = Template;
			this.AnalysisRule = AnalysisRule;
			this.AnalysisRulePlugIn = AnalysisRulePlugIn;
			this.TimeRule = TimeRule;
			this.TimeRulePlugIn = TimeRulePlugIn;
			this.Security = Security;
			this.SecurityEntries = SecurityEntries;
		}

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "Target", EmitDefaultValue = false)]
		public string Target { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "Template", EmitDefaultValue = false)]
		public string Template { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "AnalysisRule", EmitDefaultValue = false)]
		public string AnalysisRule { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "AnalysisRulePlugIn", EmitDefaultValue = false)]
		public string AnalysisRulePlugIn { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "TimeRule", EmitDefaultValue = false)]
		public string TimeRule { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "TimeRulePlugIn", EmitDefaultValue = false)]
		public string TimeRulePlugIn { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		/// <summary>
		/// Gets or Sets PIAnalysisLinks
		/// </summary>
		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
