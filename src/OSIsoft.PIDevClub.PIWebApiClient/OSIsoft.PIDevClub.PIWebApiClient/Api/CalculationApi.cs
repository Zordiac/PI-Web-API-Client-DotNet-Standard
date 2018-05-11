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
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Linq;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;

namespace OSIsoft.PIDevClub.PIWebApiClient.Api
{


	/// <summary>
	/// Represents a collection of functions to interact with the PI Web API Calculation controller.
	/// </summary>
	public interface ICalculationApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetAtIntervals(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null);

		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetAtIntervalsWithHttpInfo(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null);

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetAtRecorded(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null);

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetAtRecordedWithHttpInfo(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null);

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PIItemsSummaryValue</returns>
		PIItemsSummaryValue GetSummary(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null);

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PIItemsSummaryValue></returns>
		ApiResponse<PIItemsSummaryValue> GetSummaryWithHttpInfo(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null);

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PITimedValues</returns>
		PITimedValues GetAtTimes(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null);

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		ApiResponse<PITimedValues> GetAtTimesWithHttpInfo(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetAtIntervalsAsync(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetAtIntervalsAsyncWithHttpInfo(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetAtRecordedAsync(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetAtRecordedAsyncWithHttpInfo(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSummaryValue></returns>
		System.Threading.Tasks.Task<PIItemsSummaryValue> GetSummaryAsync(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>> GetSummaryAsyncWithHttpInfo(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		System.Threading.Tasks.Task<PITimedValues> GetAtTimesAsync(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetAtTimesAsyncWithHttpInfo(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null, CancellationTokenSource cancellationTokenSource = null);

		#endregion
	}

	public class CalculationApi : ICalculationApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public CalculationApi(Configuration configuration = null)
		{
			this.Configuration = configuration;
			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		#region Synchronous Operations
		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetAtIntervals(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetAtIntervalsWithHttpInfo(endTime, expression, sampleInterval, selectedFields, startTime, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetAtIntervalsWithHttpInfo(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null)
		{

			var localVarPath = "/calculation/intervals";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtIntervalsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetAtRecorded(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetAtRecordedWithHttpInfo(endTime, expression, selectedFields, startTime, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetAtRecordedWithHttpInfo(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null)
		{

			var localVarPath = "/calculation/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtRecordedWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PIItemsSummaryValue</returns>
		public PIItemsSummaryValue GetSummary(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null)
		{
			ApiResponse<PIItemsSummaryValue> localVarResponse = GetSummaryWithHttpInfo(calculationBasis, endTime, expression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryType, timeType, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PIItemsSummaryValue></returns>
		public ApiResponse<PIItemsSummaryValue> GetSummaryWithHttpInfo(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null)
		{

			var localVarPath = "/calculation/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", calculationBasis, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (sampleType!= null) localVarQueryParams.Add("sampleType", sampleType, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", summaryDuration, false);
			if (summaryType!= null) localVarQueryParams.Add("summaryType", summaryType, true);
			if (timeType!= null) localVarQueryParams.Add("timeType", timeType, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummaryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSummaryValue>(localVarStatusCode,
				(PIItemsSummaryValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSummaryValue)));
		}

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>PITimedValues</returns>
		public PITimedValues GetAtTimes(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null)
		{
			ApiResponse<PITimedValues> localVarResponse = GetAtTimesWithHttpInfo(expression, selectedFields, sortOrder, time, webId);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <returns>ApiResponse<PITimedValues></returns>
		public ApiResponse<PITimedValues> GetAtTimesWithHttpInfo(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null)
		{

			var localVarPath = "/calculation/times";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtTimesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetAtIntervalsAsync(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetAtIntervalsAsyncWithHttpInfo(endTime, expression, sampleInterval, selectedFields, startTime, webId, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetAtIntervalsAsyncWithHttpInfo(string endTime = null, string expression = null, string sampleInterval = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{

			var localVarPath = "/calculation/intervals";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtIntervalsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetAtRecordedAsync(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetAtRecordedAsyncWithHttpInfo(endTime, expression, selectedFields, startTime, webId, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetAtRecordedAsyncWithHttpInfo(string endTime = null, string expression = null, string selectedFields = null, string startTime = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{

			var localVarPath = "/calculation/recorded";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtRecordedAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSummaryValue></returns>
		public async System.Threading.Tasks.Task<PIItemsSummaryValue> GetSummaryAsync(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PIItemsSummaryValue> localVarResponse = await GetSummaryAsyncWithHttpInfo(calculationBasis, endTime, expression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryType, timeType, webId, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="calculationBasis">Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.</param>
		/// <param name="endTime">An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.</param>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="sampleInterval">A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.</param>
		/// <param name="sampleType">A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="startTime">An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.</param>
		/// <param name="summaryDuration">The duration of each summary interval.</param>
		/// <param name="summaryType">Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.</param>
		/// <param name="timeType">Specifies how to calculate the timestamp for each interval. The default is 'Auto'.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSummaryValue>> GetSummaryAsyncWithHttpInfo(string calculationBasis = null, string endTime = null, string expression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{

			var localVarPath = "/calculation/summary";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", calculationBasis, false);
			if (endTime!= null) localVarQueryParams.Add("endTime", endTime, false);
			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", sampleInterval, false);
			if (sampleType!= null) localVarQueryParams.Add("sampleType", sampleType, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (startTime!= null) localVarQueryParams.Add("startTime", startTime, false);
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", summaryDuration, false);
			if (summaryType!= null) localVarQueryParams.Add("summaryType", summaryType, true);
			if (timeType!= null) localVarQueryParams.Add("timeType", timeType, false);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummaryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSummaryValue>(localVarStatusCode,
				(PIItemsSummaryValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSummaryValue)));
		}

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PITimedValues></returns>
		public async System.Threading.Tasks.Task<PITimedValues> GetAtTimesAsync(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{
			ApiResponse<PITimedValues> localVarResponse = await GetAtTimesAsyncWithHttpInfo(expression, selectedFields, sortOrder, time, webId, cancellationTokenSource);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Returns the result of evaluating the expression at the specified timestamps.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="expression">A string containing the expression to be evaluated. The syntax for the expression generally follows the Performance Equation syntax as described in the PI Server documentation, with the exception that expressions which target AF objects use attribute names in place of tag names in the equation.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="time">A list of timestamps at which to calculate the expression.</param>
		/// <param name="webId">The ID of the target object of the expression. A target object can be a Data Server, a database, an element, an event frame or an attribute. References to attributes or points are based on the target. If this parameter is not provided, the target object is set to null.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PITimedValues>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PITimedValues>> GetAtTimesAsyncWithHttpInfo(string expression = null, string selectedFields = null, string sortOrder = null, List<string> time = null, string webId = null, CancellationTokenSource cancellationTokenSource = null)
		{

			var localVarPath = "/calculation/times";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (expression!= null) localVarQueryParams.Add("expression", expression, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (time!= null) localVarQueryParams.Add("time", time, true);
			if (webId!= null) localVarQueryParams.Add("webId", webId, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationTokenSource);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAtTimesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PITimedValues>(localVarStatusCode,
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		#endregion
	}
}
