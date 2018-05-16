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
	/// PINotificationRuleTemplate
	/// </summary>
	[DataContract]

	public class PINotificationRuleTemplate
	{
		public PINotificationRuleTemplate(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, List<string> CategoryNames = null, string Criteria = null, string MultiTriggerEventOption = null, string NonrepetitionInterval = null, string ResendInterval = null, string Status = null, string TemplateName = null, PIWebException WebException = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.CategoryNames = CategoryNames;
			this.Criteria = Criteria;
			this.MultiTriggerEventOption = MultiTriggerEventOption;
			this.NonrepetitionInterval = NonrepetitionInterval;
			this.ResendInterval = ResendInterval;
			this.Status = Status;
			this.TemplateName = TemplateName;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public List<string> CategoryNames { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "Criteria", EmitDefaultValue = false)]
		public string Criteria { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "MultiTriggerEventOption", EmitDefaultValue = false)]
		public string MultiTriggerEventOption { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "NonrepetitionInterval", EmitDefaultValue = false)]
		public string NonrepetitionInterval { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "ResendInterval", EmitDefaultValue = false)]
		public string ResendInterval { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleTemplate
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
