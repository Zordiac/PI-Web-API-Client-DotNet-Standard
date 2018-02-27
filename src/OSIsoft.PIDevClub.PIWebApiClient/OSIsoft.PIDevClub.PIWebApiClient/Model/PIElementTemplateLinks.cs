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
	/// PIElementTemplateLinks
	/// </summary>
	[DataContract]

	public class PIElementTemplateLinks
	{
		public PIElementTemplateLinks(string Self = null, string AnalysisTemplates = null, string AttributeTemplates = null, string Database = null, string Categories = null, string BaseTemplate = null, string DefaultAttribute = null, string Security = null, string SecurityEntries = null)
		{
			this.Self = Self;
			this.AnalysisTemplates = AnalysisTemplates;
			this.AttributeTemplates = AttributeTemplates;
			this.Database = Database;
			this.Categories = Categories;
			this.BaseTemplate = BaseTemplate;
			this.DefaultAttribute = DefaultAttribute;
			this.Security = Security;
			this.SecurityEntries = SecurityEntries;
		}

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "AnalysisTemplates", EmitDefaultValue = false)]
		public string AnalysisTemplates { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "AttributeTemplates", EmitDefaultValue = false)]
		public string AttributeTemplates { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "BaseTemplate", EmitDefaultValue = false)]
		public string BaseTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "DefaultAttribute", EmitDefaultValue = false)]
		public string DefaultAttribute { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		/// <summary>
		/// Gets or Sets PIElementTemplateLinks
		/// </summary>
		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
