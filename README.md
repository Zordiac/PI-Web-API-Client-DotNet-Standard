PI Web API client library for .NET Standard (2018)
===


## Overview
This repository has the source code package of the PI Web API Client libraries for .NET Standard, which is compatible with .NET Framework and .NET Core.

.NET Core is a cross-platform, open source, and modular .NET platform for creating modern web apps, microservices, libraries and console applications. Click [here](https://blogs.msdn.microsoft.com/dotnet/2016/06/27/announcing-net-core-1-0/) to read the official announcement.

Nevertheless, PI AF SDK is not compatible with .NET Core yet. Therefore, this library will help our community develop modern apps on top of the PI System developed on .NET Standard.

We have tested it on Windows, but it should work on Linux and OS X as well.

This version was developed on top of the PI Web API 2018 swagger specification. 


## Requirements

 - PI Web API 2018 installed within your domain using Kerberos or Basic Authentication. If you are using an older version, some methods might not work.
 - .NET Core 2.0+ or .NET Framework 4.6+

 
## Installation

 - Create a new .NET Core or .NET Framework project.
 - Open the NuGet Package Manager and run:  
 
 ```
Install-Package OSIsoft.PIDevClub.PIWebApiClient
  ```

## Documentation

All classes and methods are described on the [DOCUMENTATION](DOCUMENTATION.md).

## Notes

 - Is is highly recommended to turn debug mode on in case you are using PI Web API 2017 R2+ in order to receive more detailed exception errors. This can be achieved by creating or editing the DebugMode attribute's value to TRUE from the System Configuration element.
 - The X-Requested-With header is added to work with CSRF defences.

## Feedback 

Plese provide feedback by commenting the related [PI Developer Club blog post](https://pisquare.osisoft.com/community/developers-club/blog/2017/07/10/announcing-pi-web-api-wrapper-for-vba).

## Examples

Please check the [Program.cs](/src/OSIsoft.PIDevClub.PIWebApiClient/LibraryTest/Program.cs) from the LibraryTest project from the Visual Studio solution of this repository. Below there are also code snippets written in C# for you to get started using this library:


### Create an instance of the PI Web API top level object using Kerberos authentication.

```cs
    PIWebApiClient client = new PIWebApiClient("https://marc-web-sql.marc.net/piwebapi", true);  
``` 

### Create an instance of the PI Web API top level object using Basic authentication.

```cs
    PIWebApiClient client = new PIWebApiClient("https://marc-web-sql.marc.net/piwebapi", false, username, password);  
``` 

If you want to use basic authentication instead of Kerberos, set useKerberos to false and set the username and password accordingly.


### Get the PI Data Archive WebId

```cs
    PIDataServer dataServer = client.DataServer.GetByPath("\\\\MARC-PI2016");
```

### Create a new PI Point

```cs
    PIPoint newPIPoint = new PIPoint();
    newPIPoint.Name = "MyNewPIPoint"
    newPIPoint.Descriptor = "Point created for wrapper test"
    newPIPoint.PointClass = "classic"
    newPIPoint.PointType = "Float32"
    ApiResponseObject response = client.dataServer.CreatePointWithHttpInfo(dataServer.webId, newPIPoint)
```

### Get PI Points WebIds

```cs
    PIPoint point1 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoid");
    PIPoint point2 = client.Point.GetByPath("\\\\marc-pi2016\\sinusoidu");
    PIPoint point3 = client.Point.GetByPath("\\\\marc-pi2016\\cdt158");
```

### Get recorded values in bulk using the StreamSet/GetRecordedAdHoc

```cs
    List<string> webIds = new List<string>() { point1.WebId, point2.WebId, point3.WebId };
    PIItemsStreamValues piItemsStreamValues = client.StreamSet.GetRecordedAdHoc(webIds, startTime: "*-3d", endTime: "*");
```

### Send values in bulk using the StreamSet/UpdateValuesAdHoc

```cs
    var streamValuesItems = new PIItemsStreamValues();
    var streamValue1 = new PIStreamValues();
    var streamValue2 = new PIStreamValues();
    var streamValue3 = new PIStreamValues();
    var value1 = new PITimedValue();
    var value2 = new PITimedValue();
    var value3 = new PITimedValue();
    var value4 = new PITimedValue();
    var value5 = new PITimedValue();
    var value6 = new PITimedValue();
    value1.Value = 2;
    value1.Timestamp = "*-1d";
    value2.Value = 3;
    value2.Timestamp = "*-2d";
    value3.Value = 4;
    value3.Timestamp = "*-1d";
    value4.Value = 5;
    value4.Timestamp = "*-2d";
    value5.Value = 6;
    value5.Timestamp = "*-1d";
    value6.Value = 7;
    value6.Timestamp = "*-2d";
    streamValue1.WebId = point1.WebId;
    streamValue1.Items = new List<PITimedValue>();
    streamValue1.Items.Add(value1);
    streamValue1.Items.Add(value2);
    streamValue2.WebId = point2.WebId;
    streamValue2.Items = new List<PITimedValue>();
    streamValue2.Items.Add(value3);
    streamValue2.Items.Add(value4);
    streamValue3.WebId = point2.WebId;
    streamValue3.Items = new List<PITimedValue>();
    streamValue3.Items.Add(value5);
    streamValue3.Items.Add(value6);
    ApiResponse<PIItemsItemsSubstatus> response2 = client.StreamSet.UpdateValuesAdHocWithHttpInfo(new List<PIStreamValues>() { streamValue1, streamValue2, streamValue3 });
```


### Get element and its attributes given an AF Element path

```cs
    PIElement myElement = client.Element.GetByPath("\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm");
    PIItemsAttribute attributes = client.Element.GetAttributes(myElement.WebId, null, 1000, null, false);
```


### Get current value given an AF Attribute path

```cs
    PIAttribute attribute = client.Attribute.GetByPath(string.Format("{0}|{1}", "\\\\MARC-PI2016\\CrossPlatformLab\\marc.adm", attributes.Items[0].Name));
    PITimedValue value = client.Stream.GetEnd(attribute.WebId);
```

### Get Event Frames given an AF Database path

```cs
    PIAssetDatabase db = client.AssetData.GetByPath(path);
    PIItemsEventFrame efs = client.AssetData.GetEventFrames(db.WebId, referencedElementNameFilter: "myElement", referencedElementTemplateName: "user", startTime: "*-1d", endTime: "*");
```

### PI Web API Batch

```java
    Dictionary<string, PIRequest> batch = new Dictionary<string, PIRequest>()
    {
		{ "1", new PIRequest("GET", "https://localhost/piwebapi/points?path=\\\\SATURN-MARCOS\\sinusoid") },
		{ "2", new PIRequest("GET", "https://localhost/piwebapi/points?path=\\\\SATURN-MARCOS\\cdt158") },
		{ "3", new PIRequest() {
				Method = "GET",
				Resource = "https://localhost/piwebapi/streamsets/value?webid={0}&webid={1}",
				Parameters = new List<string>() { "$.1.Content.WebId", "$.2.Content.WebId" },
				ParentIds = new List<string>() { "1", "2" }
			}
		}
    };
    Dictionary<string, PIResponse> batchResponse = await client.BatchApi.ExecuteAsync(batch);

    if (batchResponse.All(r => r.Value.Status == 200))
    {
		PIPoint pointBatch1 = JsonConvert.DeserializeObject<PIPoint>(batchResponse["1"].Content.ToString());
		PIPoint pointBatch2 = JsonConvert.DeserializeObject<PIPoint>(batchResponse["2"].Content.ToString());
		PIItemsStreamValue batchStreamValues = JsonConvert.DeserializeObject<PIItemsStreamValue>(batchResponse["3"].Content.ToString());
		foreach (PIStreamValue piStreamValue in batchStreamValues.Items)
		{
			Console.WriteLine("PI Point: {0}, Value: {1}, Timestamp: {2}", piStreamValue.Name, piStreamValue.Value.Value, piStreamValue.Value.Timestamp);
		}
    }
```


### Getting WebID 2.0 information

```cs
	string webIdType = "Full";
	PIAssetServer piAssetServer = client.AssetServer.GetByPath(Constants.AF_SERVER_PATH, null, webIdType);
	WebIdInfo piAssetServerWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAssetServer.WebId);

	PIAttribute piAttribute = client.Attribute.GetByPath(Constants.AF_ATTRIBUTE_PATH, null, webIdType);
	WebIdInfo piAttributeWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttribute.WebId);
```


### Generating WebID 2.0 client side

```cs
	string webId1 = client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ATTRIBUTE_PATH, typeof(PIAttribute), typeof(PIElement));
	string webId2 = client.WebIdHelper.GenerateWebIdByPath(Constants.PI_DATA_SERVER_PATH, typeof(PIDataServer));
```

### Cancelling the HTTP request with the CancellationTokenSource

```cs
	Stopwatch watch = Stopwatch.StartNew();
	CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
	PIItemsStreamValues bulkValues = null;
	try
	{
		Task t = Task.Run(async () =>
		{
			bulkValues = await client.StreamSet.GetRecordedAdHocAsync(webId: webIds, startTime: "*-1800d", endTime: "*", maxCount: 50000, cancellationTokenSource: cancellationTokenSource);
		});
		System.Threading.Thread.Sleep(4000);
		cancellationTokenSource.Cancel();
		t.Wait();
		Console.WriteLine("Completed task: Time elapsed: {0}s", 0.001 * watch.ElapsedMilliseconds);
	}
	catch (Exception)
	{
		Console.WriteLine("Cancelled task: Time elapsed: {0}s", 0.001 * watch.ElapsedMilliseconds);
	};
```


## Licensing
Copyright 2018 OSIsoft, LLC.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   
Please see the file named [LICENSE.md](LICENSE.md).
