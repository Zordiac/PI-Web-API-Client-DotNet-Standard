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
	/// PIChannelInstance
	/// </summary>
	[DataContract]

	public class PIChannelInstance
	{
		public PIChannelInstance(string Id = null, string StartTime = null, string LastMessageSentTime = null, int? SentMessageCount = null, PIWebException WebException = null)
		{
			this.Id = Id;
			this.StartTime = StartTime;
			this.LastMessageSentTime = LastMessageSentTime;
			this.SentMessageCount = SentMessageCount;
			this.WebException = WebException;
		}

		/// <summary>
		/// Gets or Sets PIChannelInstance
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets PIChannelInstance
		/// </summary>
		[DataMember(Name = "StartTime", EmitDefaultValue = false)]
		public string StartTime { get; set; }

		/// <summary>
		/// Gets or Sets PIChannelInstance
		/// </summary>
		[DataMember(Name = "LastMessageSentTime", EmitDefaultValue = false)]
		public string LastMessageSentTime { get; set; }

		/// <summary>
		/// Gets or Sets PIChannelInstance
		/// </summary>
		[DataMember(Name = "SentMessageCount", EmitDefaultValue = false)]
		public int? SentMessageCount { get; set; }

		/// <summary>
		/// Gets or Sets PIChannelInstance
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
