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
	/// PINotificationRuleSubscriber
	/// </summary>
	[DataContract]

	public class PINotificationRuleSubscriber
	{
		public PINotificationRuleSubscriber(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, string ConfigString = null, string ContactTemplateName = null, string ContactType = null, string DeliveryFormatName = null, string PlugInName = null, string EscalationTimeout = null, int? MaximumRetries = null, string NotifyOption = null, string RetryInterval = null, PIWebException WebException = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.ConfigString = ConfigString;
			this.ContactTemplateName = ContactTemplateName;
			this.ContactType = ContactType;
			this.DeliveryFormatName = DeliveryFormatName;
			this.PlugInName = PlugInName;
			this.EscalationTimeout = EscalationTimeout;
			this.MaximumRetries = MaximumRetries;
			this.NotifyOption = NotifyOption;
			this.RetryInterval = RetryInterval;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "ContactTemplateName", EmitDefaultValue = false)]
		public string ContactTemplateName { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "ContactType", EmitDefaultValue = false)]
		public string ContactType { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "DeliveryFormatName", EmitDefaultValue = false)]
		public string DeliveryFormatName { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "PlugInName", EmitDefaultValue = false)]
		public string PlugInName { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "EscalationTimeout", EmitDefaultValue = false)]
		public string EscalationTimeout { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "MaximumRetries", EmitDefaultValue = false)]
		public int? MaximumRetries { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "NotifyOption", EmitDefaultValue = false)]
		public string NotifyOption { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "RetryInterval", EmitDefaultValue = false)]
		public string RetryInterval { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationRuleSubscriber
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
