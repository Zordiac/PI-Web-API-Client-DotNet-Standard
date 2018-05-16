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
	/// PINotificationContactTemplate
	/// </summary>
	[DataContract]

	public class PINotificationContactTemplate
	{
		public PINotificationContactTemplate(string WebId = null, string Id = null, string Name = null, string Description = null, string Path = null, bool? Available = null, string ConfigString = null, string ContactType = null, string PlugInName = null, bool? HasChildren = null, int? MaximumRetries = null, int? MinimumAcknowledgements = null, bool? NotifyWhenInstanceEnded = null, string EscalationTimeout = null, string RetryInterval = null, PINotificationContactTemplateLinks Links = null, PIWebException WebException = null)
		{
			this.WebId = WebId;
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Path = Path;
			this.Available = Available;
			this.ConfigString = ConfigString;
			this.ContactType = ContactType;
			this.PlugInName = PlugInName;
			this.HasChildren = HasChildren;
			this.MaximumRetries = MaximumRetries;
			this.MinimumAcknowledgements = MinimumAcknowledgements;
			this.NotifyWhenInstanceEnded = NotifyWhenInstanceEnded;
			this.EscalationTimeout = EscalationTimeout;
			this.RetryInterval = RetryInterval;
			this.Links = Links;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "Available", EmitDefaultValue = false)]
		public bool? Available { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "ContactType", EmitDefaultValue = false)]
		public string ContactType { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "PlugInName", EmitDefaultValue = false)]
		public string PlugInName { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool? HasChildren { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "MaximumRetries", EmitDefaultValue = false)]
		public int? MaximumRetries { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "MinimumAcknowledgements", EmitDefaultValue = false)]
		public int? MinimumAcknowledgements { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "NotifyWhenInstanceEnded", EmitDefaultValue = false)]
		public bool? NotifyWhenInstanceEnded { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "EscalationTimeout", EmitDefaultValue = false)]
		public string EscalationTimeout { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "RetryInterval", EmitDefaultValue = false)]
		public string RetryInterval { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PINotificationContactTemplateLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets PINotificationContactTemplate
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
