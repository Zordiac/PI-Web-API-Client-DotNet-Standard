// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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

using NUnit.Framework;
using OSIsoft.AF;
using OSIsoft.AF.EventFrame;
using OSIsoft.AF.UnitsOfMeasure;
using OSIsoft.PIDevClub.PIWebApiClient.Api;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using OSIsoft.PIDevClub.PIWebApiClient.WebID;
//using OSIsoft.WebID;

namespace OSIsoft.PIDevClub.PIWebApiClient.Test.Api
{
    public class WebIdBuilderTests : CommonApi
    {
        private IWebIdHelper instance;


        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            base.CommonInit();
            instance = client.WebIdHelper;
            base.CreateSampleDatabaseForTests();
        }
        /// <summary>
        /// Test an instance of UnitClassApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf(typeof(WebIdHelper), instance, "instance is a WebIdBuilder");
        }


        /// <summary>
        /// Test GetWebIDFull for all types
        /// </summary>
        [Test]
        public void GetWebIDOnlyTest()
        {
            string webIdType = "IDOnly";
            PIAnalysis piAnalysis = client.Analysis.GetByPath(Constants.AF_ANALYSIS_PATH, null, webIdType);
            WebIdInfo piAnalysisWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysis.WebId);
            Assert.AreNotEqual(Constants.AF_ANALYSIS_PATH.ToUpper().Substring(2), piAnalysisWebIdInfo.Path);
            Assert.AreEqual(piAnalysis.Id, piAnalysisWebIdInfo.ObjectID.ToString());

            PIAnalysisCategory piAnalysisCategory = client.AnalysisCategory.GetByPath(Constants.AF_ANALYSIS_CATEGORY_PATH, null, webIdType);
            WebIdInfo piAnalysisCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisCategory.WebId);
            Assert.AreNotEqual(Constants.AF_ANALYSIS_CATEGORY_PATH.ToUpper().Substring(2), piAnalysisCategoryWebIdInfo.Path);
            Assert.AreEqual(piAnalysisCategory.Id, piAnalysisCategoryWebIdInfo.ObjectID.ToString());

            PIAnalysisRule piAnalysisRule = client.AnalysisRule.GetByPath(Constants.AF_ANALYSIS_RULE_PATH, null, webIdType);
            WebIdInfo piAnalysisRuleWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisRule.WebId);
            Assert.AreNotEqual(Constants.AF_ANALYSIS_RULE_PATH.ToUpper().Substring(2), piAnalysisRuleWebIdInfo.Path);
            Assert.AreEqual(piAnalysisRule.Id, piAnalysisRuleWebIdInfo.ObjectID.ToString());


            PIAnalysisRulePlugIn piAnalysisRulePlugIn = client.AnalysisRulePlugIn.GetByPath(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH, null, webIdType);
            WebIdInfo piAnalysisRulePlugInWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisRulePlugIn.WebId);
            Assert.AreNotEqual(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH.ToUpper().Substring(2), piAnalysisRulePlugInWebIdInfo.Path);
            Assert.AreEqual(piAnalysisRulePlugIn.Id, piAnalysisRulePlugInWebIdInfo.ObjectID.ToString());

            PIAnalysisTemplate piAnalysisTemplate = client.AnalysisTemplate.GetByPath(Constants.AF_ANALYSIS_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piAnalysisTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisTemplate.WebId);
            Assert.AreNotEqual(Constants.AF_ANALYSIS_TEMPLATE_PATH.ToUpper().Substring(2), piAnalysisTemplateWebIdInfo.Path);
            Assert.AreEqual(piAnalysisTemplate.Id, piAnalysisTemplateWebIdInfo.ObjectID.ToString());


            PIAssetDatabase piAssetDatabase = client.AssetDatabase.GetByPath(Constants.AF_DATABASE_PATH, null, webIdType);
            WebIdInfo piAssetDatabaseWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAssetDatabase.WebId);
            Assert.AreNotEqual(Constants.AF_DATABASE_PATH.ToUpper().Substring(2), piAssetDatabaseWebIdInfo.Path);
            Assert.AreEqual(piAssetDatabase.Id, piAssetDatabaseWebIdInfo.ObjectID.ToString());


            PIAssetServer piAssetServer = client.AssetServer.GetByPath(Constants.AF_SERVER_PATH, null, webIdType);
            WebIdInfo piAssetServerWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAssetServer.WebId);
            Assert.AreNotEqual(Constants.AF_SERVER_PATH.ToUpper().Substring(2), piAssetServerWebIdInfo.Path);
            Assert.AreEqual(piAssetServer.Id, piAssetServerWebIdInfo.ServerID.ToString());


            PIAttribute piAttribute = client.Attribute.GetByPath(Constants.AF_ATTRIBUTE_PATH, null, webIdType);
            WebIdInfo piAttributeWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttribute.WebId);
            Assert.AreNotEqual(Constants.AF_ATTRIBUTE_PATH.ToUpper().Substring(2), piAttributeWebIdInfo.Path);
            Assert.AreEqual(piAttribute.Id, piAttributeWebIdInfo.ObjectID.ToString());


            PIAttributeCategory piAttributeCategory = client.AttributeCategory.GetByPath(Constants.AF_ATTRIBUTE_CATEGORY_PATH, null, webIdType);
            WebIdInfo piAttributeCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttributeCategory.WebId);
            Assert.AreNotEqual(Constants.AF_ATTRIBUTE_CATEGORY_PATH.ToUpper().Substring(2), piAttributeCategoryWebIdInfo.Path);
            Assert.AreEqual(piAttributeCategory.Id, piAttributeCategoryWebIdInfo.ObjectID.ToString());

            PIAttributeTemplate piAttributeTemplate = client.AttributeTemplate.GetByPath(Constants.AF_ATTRIBUTE_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piAttributeTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttributeTemplate.WebId);
            Assert.AreNotEqual(Constants.AF_ATTRIBUTE_TEMPLATE_PATH.ToUpper().Substring(2), piAttributeTemplateWebIdInfo.Path);
            Assert.AreEqual(piAttributeTemplate.Id, piAttributeTemplateWebIdInfo.ObjectID.ToString());


            PIDataServer piDataServer = client.DataServer.GetByPath(Constants.PI_DATA_SERVER_PATH, null, webIdType);
            WebIdInfo piDataServerWebIdInfo = client.WebIdHelper.GetWebIdInfo(piDataServer.WebId);
            Assert.AreNotEqual(Constants.PI_DATA_SERVER_PATH.ToUpper().Substring(2), piDataServerWebIdInfo.Path);
            Assert.AreEqual(piDataServer.Id, piDataServerWebIdInfo.ServerID.ToString());


            PIElement piElement = client.Element.GetByPath(Constants.AF_ELEMENT_PATH, null, webIdType);
            WebIdInfo piElementWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElement.WebId);
            Assert.AreNotEqual(Constants.AF_ELEMENT_PATH.ToUpper().Substring(2), piElementWebIdInfo.Path);
            Assert.AreEqual(piElement.Id, piElementWebIdInfo.ObjectID.ToString());

            PIElementCategory piElementCategory = client.ElementCategory.GetByPath(Constants.AF_ELEMENT_CATEGORY_PATH, null, webIdType);
            WebIdInfo piElementCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElementCategory.WebId);
            Assert.AreNotEqual(Constants.AF_ELEMENT_CATEGORY_PATH.ToUpper().Substring(2), piElementCategoryWebIdInfo.Path);
            Assert.AreEqual(piElementCategory.Id, piElementCategoryWebIdInfo.ObjectID.ToString());


            PIElementTemplate piElementTemplate = client.ElementTemplate.GetByPath(Constants.AF_ELEMENT_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piElementTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElementTemplate.WebId);
            Assert.AreNotEqual(Constants.AF_ELEMENT_TEMPLATE_PATH.ToUpper().Substring(2), piElementTemplateWebIdInfo.Path);
            Assert.AreEqual(piElementTemplate.Id, piElementTemplateWebIdInfo.ObjectID.ToString());


            PIEnumerationSet piEnumerationSet = client.EnumerationSet.GetByPath(Constants.AF_ENUMERATION_SET_PATH, null, webIdType);
            WebIdInfo piEnumerationSetWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationSet.WebId);
            Assert.AreNotEqual(Constants.AF_ENUMERATION_SET_PATH.ToUpper().Substring(2), piEnumerationSetWebIdInfo.Path);
            Assert.AreEqual(piEnumerationSet.Id, piEnumerationSetWebIdInfo.ObjectID.ToString());


            PIEnumerationValue piEnumerationValue = client.EnumerationValue.GetByPath(Constants.AF_ENUMERATION_VALUE_PATH, null, webIdType);
            WebIdInfo piEnumerationValueWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationValue.WebId);
            Assert.AreNotEqual(Constants.AF_ENUMERATION_VALUE_PATH.ToUpper().Substring(2), piEnumerationValueWebIdInfo.Path);
            Assert.AreEqual(piEnumerationValue.Id, piEnumerationValueWebIdInfo.ObjectID.ToString());


            PIEventFrame piEventFrame = client.EventFrame.GetByPath(Constants.AF_EVENT_FRAME_PATH, null, webIdType);
            WebIdInfo piEventFrameWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEventFrame.WebId);
            Assert.AreNotEqual(Constants.AF_EVENT_FRAME_PATH.ToUpper().Substring(2), piEventFrameWebIdInfo.Path);
            Assert.AreEqual(piEventFrame.Id, piEventFrameWebIdInfo.ObjectID.ToString());


            PIPoint piPoint = client.Point.GetByPath(Constants.PI_POINT_PATH, null, webIdType);
            WebIdInfo piPointWebIdInfo = client.WebIdHelper.GetWebIdInfo(piPoint.WebId);
            Assert.AreNotEqual(Constants.PI_POINT_PATH.ToUpper().Substring(2), piPointWebIdInfo.Path);
            Assert.AreEqual(piPoint.Id.ToString(), piPointWebIdInfo.PointID.ToString());


            PISecurityIdentity piSecurityIdentity = client.SecurityIdentity.GetByPath(Constants.AF_SECURITY_IDENTITY_PATH, null, webIdType);
            WebIdInfo piSecurityIdentityWebIdInfo = client.WebIdHelper.GetWebIdInfo(piSecurityIdentity.WebId);
            Assert.AreNotEqual(Constants.AF_SECURITY_IDENTITY_PATH.ToUpper().Substring(2), piSecurityIdentityWebIdInfo.Path);
            Assert.AreEqual(piSecurityIdentity.Id, piSecurityIdentityWebIdInfo.ObjectID.ToString());


            PISecurityMapping piSecurityMapping = client.SecurityMapping.GetByPath(Constants.AF_SECURITY_MAPPING_PATH, null, webIdType);
            WebIdInfo piSecurityMappingWebIdInfo = client.WebIdHelper.GetWebIdInfo(piSecurityMapping.WebId);
            Assert.AreNotEqual(Constants.AF_SECURITY_MAPPING_PATH.ToUpper().Substring(2), piSecurityMappingWebIdInfo.Path);
            Assert.AreEqual(piSecurityMapping.Id, piSecurityMappingWebIdInfo.ObjectID.ToString());


            PITable piTable = client.Table.GetByPath(Constants.AF_TABLE_PATH, null, webIdType);
            WebIdInfo piTableWebIdInfo = client.WebIdHelper.GetWebIdInfo(piTable.WebId);
            Assert.AreNotEqual(Constants.AF_TABLE_PATH.ToUpper().Substring(2), piTableWebIdInfo.Path);
            Assert.AreEqual(piTable.Id, piTableWebIdInfo.ObjectID.ToString());

            PITableCategory piTableCategory = client.TableCategory.GetByPath(Constants.AF_TABLE_CATEGORY_PATH, null, webIdType);
            WebIdInfo piTableCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piTableCategory.WebId);
            Assert.AreNotEqual(Constants.AF_TABLE_CATEGORY_PATH.ToUpper().Substring(2), piTableCategoryWebIdInfo.Path);
            Assert.AreEqual(piTableCategory.Id, piTableCategoryWebIdInfo.ObjectID.ToString());


            PIUnit piUnit = client.Unit.GetByPath(Constants.AF_UOM_PATH, null, webIdType);
            WebIdInfo piUnitWebIdInfo = client.WebIdHelper.GetWebIdInfo(piUnit.WebId);
            Assert.AreNotEqual(Constants.AF_UOM_PATH.ToUpper().Substring(2), piUnitWebIdInfo.Path);
            Assert.AreEqual(piUnit.Id, piUnitWebIdInfo.ObjectID.ToString());


            PIUnitClass piUnitClass = client.UnitClass.GetByPath(Constants.AF_UOM_CLASS_PATH, null, webIdType);
            WebIdInfo piUnitClassWebIdInfo = client.WebIdHelper.GetWebIdInfo(piUnitClass.WebId);
            Assert.AreNotEqual(Constants.AF_UOM_CLASS_PATH.ToUpper().Substring(2), piUnitClassWebIdInfo.Path);
            Assert.AreEqual(piUnitClass.Id, piUnitClassWebIdInfo.ObjectID.ToString());


        }

        /// <summary>
        /// Test GetWebIDFull for all types
        /// </summary>
        [Test]
        public void GetWebIDPathOnlyTest()
        {
            string webIdType = "PathOnly";
            PIAnalysis piAnalysis = client.Analysis.GetByPath(Constants.AF_ANALYSIS_PATH, null, webIdType);
            WebIdInfo piAnalysisWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysis.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_PATH.ToUpper().Substring(2), piAnalysisWebIdInfo.Path);
            Assert.AreNotEqual(piAnalysis.Id, piAnalysisWebIdInfo.ObjectID.ToString());

            PIAnalysisCategory piAnalysisCategory = client.AnalysisCategory.GetByPath(Constants.AF_ANALYSIS_CATEGORY_PATH, null, webIdType);
            WebIdInfo piAnalysisCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisCategory.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_CATEGORY_PATH.ToUpper().Substring(2), piAnalysisCategoryWebIdInfo.Path);
            Assert.AreNotEqual(piAnalysisCategory.Id, piAnalysisCategoryWebIdInfo.ObjectID.ToString());

            PIAnalysisRule piAnalysisRule = client.AnalysisRule.GetByPath(Constants.AF_ANALYSIS_RULE_PATH, null, webIdType);
            WebIdInfo piAnalysisRuleWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisRule.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_RULE_PATH.ToUpper().Substring(2), piAnalysisRuleWebIdInfo.Path);
            Assert.AreNotEqual(piAnalysisRule.Id, piAnalysisRuleWebIdInfo.ObjectID.ToString());


            PIAnalysisRulePlugIn piAnalysisRulePlugIn = client.AnalysisRulePlugIn.GetByPath(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH, null, webIdType);
            WebIdInfo piAnalysisRulePlugInWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisRulePlugIn.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH.ToUpper().Substring(2), piAnalysisRulePlugInWebIdInfo.Path);
            Assert.AreNotEqual(piAnalysisRulePlugIn.Id, piAnalysisRulePlugInWebIdInfo.ObjectID.ToString());

            PIAnalysisTemplate piAnalysisTemplate = client.AnalysisTemplate.GetByPath(Constants.AF_ANALYSIS_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piAnalysisTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisTemplate.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_TEMPLATE_PATH.ToUpper().Substring(2), piAnalysisTemplateWebIdInfo.Path);
            Assert.AreNotEqual(piAnalysisTemplate.Id, piAnalysisTemplateWebIdInfo.ObjectID.ToString());


            PIAssetDatabase piAssetDatabase = client.AssetDatabase.GetByPath(Constants.AF_DATABASE_PATH, null, webIdType);
            WebIdInfo piAssetDatabaseWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAssetDatabase.WebId);
            Assert.AreEqual(Constants.AF_DATABASE_PATH.ToUpper().Substring(2), piAssetDatabaseWebIdInfo.Path);
            Assert.AreNotEqual(piAssetDatabase.Id, piAssetDatabaseWebIdInfo.ObjectID.ToString());


            PIAssetServer piAssetServer = client.AssetServer.GetByPath(Constants.AF_SERVER_PATH, null, webIdType);
            WebIdInfo piAssetServerWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAssetServer.WebId);
            Assert.AreEqual(Constants.AF_SERVER_PATH.ToUpper().Substring(2), piAssetServerWebIdInfo.Path);
            Assert.AreNotEqual(piAssetServer.Id, piAssetServerWebIdInfo.ServerID.ToString());


            PIAttribute piAttribute = client.Attribute.GetByPath(Constants.AF_ATTRIBUTE_PATH, null, webIdType);
            WebIdInfo piAttributeWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttribute.WebId);
            Assert.AreEqual(Constants.AF_ATTRIBUTE_PATH.ToUpper().Substring(2), piAttributeWebIdInfo.Path);
            Assert.AreNotEqual(piAttribute.Id, piAttributeWebIdInfo.ObjectID.ToString());


            PIAttributeCategory piAttributeCategory = client.AttributeCategory.GetByPath(Constants.AF_ATTRIBUTE_CATEGORY_PATH, null, webIdType);
            WebIdInfo piAttributeCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttributeCategory.WebId);
            Assert.AreEqual(Constants.AF_ATTRIBUTE_CATEGORY_PATH.ToUpper().Substring(2), piAttributeCategoryWebIdInfo.Path);
            Assert.AreNotEqual(piAttributeCategory.Id, piAttributeCategoryWebIdInfo.ObjectID.ToString());

            PIAttributeTemplate piAttributeTemplate = client.AttributeTemplate.GetByPath(Constants.AF_ATTRIBUTE_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piAttributeTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttributeTemplate.WebId);
            Assert.AreEqual(Constants.AF_ATTRIBUTE_TEMPLATE_PATH.ToUpper().Substring(2), piAttributeTemplateWebIdInfo.Path);
            Assert.AreNotEqual(piAttributeTemplate.Id, piAttributeTemplateWebIdInfo.ObjectID.ToString());


            PIDataServer piDataServer = client.DataServer.GetByPath(Constants.PI_DATA_SERVER_PATH, null, webIdType);
            WebIdInfo piDataServerWebIdInfo = client.WebIdHelper.GetWebIdInfo(piDataServer.WebId);
            Assert.AreEqual(Constants.PI_DATA_SERVER_PATH.ToUpper().Substring(2), piDataServerWebIdInfo.Path);
            Assert.AreNotEqual(piDataServer.Id, piDataServerWebIdInfo.ServerID.ToString());


            PIElement piElement = client.Element.GetByPath(Constants.AF_ELEMENT_PATH, null, webIdType);
            WebIdInfo piElementWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElement.WebId);
            Assert.AreEqual(Constants.AF_ELEMENT_PATH.ToUpper().Substring(2), piElementWebIdInfo.Path);
            Assert.AreNotEqual(piElement.Id, piElementWebIdInfo.ObjectID.ToString());

            PIElementCategory piElementCategory = client.ElementCategory.GetByPath(Constants.AF_ELEMENT_CATEGORY_PATH, null, webIdType);
            WebIdInfo piElementCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElementCategory.WebId);
            Assert.AreEqual(Constants.AF_ELEMENT_CATEGORY_PATH.ToUpper().Substring(2), piElementCategoryWebIdInfo.Path);
            Assert.AreNotEqual(piElementCategory.Id, piElementCategoryWebIdInfo.ObjectID.ToString());


            PIElementTemplate piElementTemplate = client.ElementTemplate.GetByPath(Constants.AF_ELEMENT_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piElementTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElementTemplate.WebId);
            Assert.AreEqual(Constants.AF_ELEMENT_TEMPLATE_PATH.ToUpper().Substring(2), piElementTemplateWebIdInfo.Path);
            Assert.AreNotEqual(piElementTemplate.Id, piElementTemplateWebIdInfo.ObjectID.ToString());


            PIEnumerationSet piEnumerationSet = client.EnumerationSet.GetByPath(Constants.AF_ENUMERATION_SET_PATH, null, webIdType);
            WebIdInfo piEnumerationSetWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationSet.WebId);
            Assert.AreEqual(Constants.AF_ENUMERATION_SET_PATH.ToUpper().Substring(2), piEnumerationSetWebIdInfo.Path);
            Assert.AreNotEqual(piEnumerationSet.Id, piEnumerationSetWebIdInfo.ObjectID.ToString());


            PIEnumerationValue piEnumerationValue = client.EnumerationValue.GetByPath(Constants.AF_ENUMERATION_VALUE_PATH, null, webIdType);
            WebIdInfo piEnumerationValueWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationValue.WebId);
            Assert.AreEqual(Constants.AF_ENUMERATION_VALUE_PATH.ToUpper().Substring(2), piEnumerationValueWebIdInfo.Path);
            Assert.AreNotEqual(piEnumerationValue.Id, piEnumerationValueWebIdInfo.ObjectID.ToString());


            PIEventFrame piEventFrame = client.EventFrame.GetByPath(Constants.AF_EVENT_FRAME_PATH, null, webIdType);
            WebIdInfo piEventFrameWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEventFrame.WebId);
            Assert.AreEqual(Constants.AF_EVENT_FRAME_PATH.ToUpper().Substring(2), piEventFrameWebIdInfo.Path);
            Assert.AreNotEqual(piEventFrame.Id, piEventFrameWebIdInfo.ObjectID.ToString());


            PIPoint piPoint = client.Point.GetByPath(Constants.PI_POINT_PATH, null, webIdType);
            WebIdInfo piPointWebIdInfo = client.WebIdHelper.GetWebIdInfo(piPoint.WebId);
            Assert.AreEqual(Constants.PI_POINT_PATH.ToUpper().Substring(2), piPointWebIdInfo.Path);
            Assert.AreNotEqual(piPoint.Id.ToString(), piPointWebIdInfo.PointID.ToString());


            PISecurityIdentity piSecurityIdentity = client.SecurityIdentity.GetByPath(Constants.AF_SECURITY_IDENTITY_PATH, null, webIdType);
            WebIdInfo piSecurityIdentityWebIdInfo = client.WebIdHelper.GetWebIdInfo(piSecurityIdentity.WebId);
            Assert.AreEqual(Constants.AF_SECURITY_IDENTITY_PATH.ToUpper().Substring(2), piSecurityIdentityWebIdInfo.Path);
            Assert.AreNotEqual(piSecurityIdentity.Id, piSecurityIdentityWebIdInfo.ObjectID.ToString());


            PISecurityMapping piSecurityMapping = client.SecurityMapping.GetByPath(Constants.AF_SECURITY_MAPPING_PATH, null, webIdType);
            WebIdInfo piSecurityMappingWebIdInfo = client.WebIdHelper.GetWebIdInfo(piSecurityMapping.WebId);
            Assert.AreEqual(Constants.AF_SECURITY_MAPPING_PATH.ToUpper().Substring(2), piSecurityMappingWebIdInfo.Path);
            Assert.AreNotEqual(piSecurityMapping.Id, piSecurityMappingWebIdInfo.ObjectID.ToString());


            PITable piTable = client.Table.GetByPath(Constants.AF_TABLE_PATH, null, webIdType);
            WebIdInfo piTableWebIdInfo = client.WebIdHelper.GetWebIdInfo(piTable.WebId);
            Assert.AreEqual(Constants.AF_TABLE_PATH.ToUpper().Substring(2), piTableWebIdInfo.Path);
            Assert.AreNotEqual(piTable.Id, piTableWebIdInfo.ObjectID.ToString());

            PITableCategory piTableCategory = client.TableCategory.GetByPath(Constants.AF_TABLE_CATEGORY_PATH, null, webIdType);
            WebIdInfo piTableCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piTableCategory.WebId);
            Assert.AreEqual(Constants.AF_TABLE_CATEGORY_PATH.ToUpper().Substring(2), piTableCategoryWebIdInfo.Path);
            Assert.AreNotEqual(piTableCategory.Id, piTableCategoryWebIdInfo.ObjectID.ToString());


            PIUnit piUnit = client.Unit.GetByPath(Constants.AF_UOM_PATH, null, webIdType);
            WebIdInfo piUnitWebIdInfo = client.WebIdHelper.GetWebIdInfo(piUnit.WebId);
            Assert.AreEqual(Constants.AF_UOM_PATH.ToUpper().Substring(2), piUnitWebIdInfo.Path);
            Assert.AreNotEqual(piUnit.Id, piUnitWebIdInfo.ObjectID.ToString());


            PIUnitClass piUnitClass = client.UnitClass.GetByPath(Constants.AF_UOM_CLASS_PATH, null, webIdType);
            WebIdInfo piUnitClassWebIdInfo = client.WebIdHelper.GetWebIdInfo(piUnitClass.WebId);
            Assert.AreEqual(Constants.AF_UOM_CLASS_PATH.ToUpper().Substring(2), piUnitClassWebIdInfo.Path);
            Assert.AreNotEqual(piUnitClass.Id, piUnitClassWebIdInfo.ObjectID.ToString());


        }

        /// <summary>
        /// Test GetWebIDFull for all types
        /// </summary>
        [Test]
        public void GetWebIDFullTest()
        {
            string webIdType = "Full";
            PIAnalysis piAnalysis = client.Analysis.GetByPath(Constants.AF_ANALYSIS_PATH, null, webIdType);
            WebIdInfo piAnalysisWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysis.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_PATH.ToUpper().Substring(2), piAnalysisWebIdInfo.Path);
            Assert.AreEqual(piAnalysis.Id, piAnalysisWebIdInfo.ObjectID.ToString());

            PIAnalysisCategory piAnalysisCategory = client.AnalysisCategory.GetByPath(Constants.AF_ANALYSIS_CATEGORY_PATH, null, webIdType);
            WebIdInfo piAnalysisCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisCategory.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_CATEGORY_PATH.ToUpper().Substring(2), piAnalysisCategoryWebIdInfo.Path);
            Assert.AreEqual(piAnalysisCategory.Id, piAnalysisCategoryWebIdInfo.ObjectID.ToString());

            PIAnalysisRule piAnalysisRule = client.AnalysisRule.GetByPath(Constants.AF_ANALYSIS_RULE_PATH, null, webIdType);
            WebIdInfo piAnalysisRuleWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisRule.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_RULE_PATH.ToUpper().Substring(2), piAnalysisRuleWebIdInfo.Path);
            Assert.AreEqual(piAnalysisRule.Id, piAnalysisRuleWebIdInfo.ObjectID.ToString());


            PIAnalysisRulePlugIn piAnalysisRulePlugIn = client.AnalysisRulePlugIn.GetByPath(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH, null, webIdType);
            WebIdInfo piAnalysisRulePlugInWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisRulePlugIn.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH.ToUpper().Substring(2), piAnalysisRulePlugInWebIdInfo.Path);
            Assert.AreEqual(piAnalysisRulePlugIn.Id, piAnalysisRulePlugInWebIdInfo.ObjectID.ToString());

            PIAnalysisTemplate piAnalysisTemplate = client.AnalysisTemplate.GetByPath(Constants.AF_ANALYSIS_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piAnalysisTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisTemplate.WebId);
            Assert.AreEqual(Constants.AF_ANALYSIS_TEMPLATE_PATH.ToUpper().Substring(2), piAnalysisTemplateWebIdInfo.Path);
            Assert.AreEqual(piAnalysisTemplate.Id, piAnalysisTemplateWebIdInfo.ObjectID.ToString());


            PIAssetDatabase piAssetDatabase = client.AssetDatabase.GetByPath(Constants.AF_DATABASE_PATH, null, webIdType);
            WebIdInfo piAssetDatabaseWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAssetDatabase.WebId);
            Assert.AreEqual(Constants.AF_DATABASE_PATH.ToUpper().Substring(2), piAssetDatabaseWebIdInfo.Path);
            Assert.AreEqual(piAssetDatabase.Id, piAssetDatabaseWebIdInfo.ObjectID.ToString());


            PIAssetServer piAssetServer = client.AssetServer.GetByPath(Constants.AF_SERVER_PATH, null, webIdType);
            WebIdInfo piAssetServerWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAssetServer.WebId);
            Assert.AreEqual(Constants.AF_SERVER_PATH.ToUpper().Substring(2), piAssetServerWebIdInfo.Path);
            Assert.AreEqual(piAssetServer.Id, piAssetServerWebIdInfo.ServerID.ToString());


            PIAttribute piAttribute = client.Attribute.GetByPath(Constants.AF_ATTRIBUTE_PATH, null, webIdType);
            WebIdInfo piAttributeWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttribute.WebId);
            Assert.AreEqual(Constants.AF_ATTRIBUTE_PATH.ToUpper().Substring(2), piAttributeWebIdInfo.Path);
            Assert.AreEqual(piAttribute.Id, piAttributeWebIdInfo.ObjectID.ToString());


            PIAttributeCategory piAttributeCategory = client.AttributeCategory.GetByPath(Constants.AF_ATTRIBUTE_CATEGORY_PATH, null, webIdType);
            WebIdInfo piAttributeCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttributeCategory.WebId);
            Assert.AreEqual(Constants.AF_ATTRIBUTE_CATEGORY_PATH.ToUpper().Substring(2), piAttributeCategoryWebIdInfo.Path);
            Assert.AreEqual(piAttributeCategory.Id, piAttributeCategoryWebIdInfo.ObjectID.ToString());

            PIAttributeTemplate piAttributeTemplate = client.AttributeTemplate.GetByPath(Constants.AF_ATTRIBUTE_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piAttributeTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttributeTemplate.WebId);
            Assert.AreEqual(Constants.AF_ATTRIBUTE_TEMPLATE_PATH.ToUpper().Substring(2), piAttributeTemplateWebIdInfo.Path);
            Assert.AreEqual(piAttributeTemplate.Id, piAttributeTemplateWebIdInfo.ObjectID.ToString());


            PIDataServer piDataServer = client.DataServer.GetByPath(Constants.PI_DATA_SERVER_PATH, null, webIdType);
            WebIdInfo piDataServerWebIdInfo = client.WebIdHelper.GetWebIdInfo(piDataServer.WebId);
            Assert.AreEqual(Constants.PI_DATA_SERVER_PATH.ToUpper().Substring(2), piDataServerWebIdInfo.Path);
            Assert.AreEqual(piDataServer.Id, piDataServerWebIdInfo.ServerID.ToString());


            PIElement piElement = client.Element.GetByPath(Constants.AF_ELEMENT_PATH, null, webIdType);
            WebIdInfo piElementWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElement.WebId);
            Assert.AreEqual(Constants.AF_ELEMENT_PATH.ToUpper().Substring(2), piElementWebIdInfo.Path);
            Assert.AreEqual(piElement.Id, piElementWebIdInfo.ObjectID.ToString());

            PIElementCategory piElementCategory = client.ElementCategory.GetByPath(Constants.AF_ELEMENT_CATEGORY_PATH, null, webIdType);
            WebIdInfo piElementCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElementCategory.WebId);
            Assert.AreEqual(Constants.AF_ELEMENT_CATEGORY_PATH.ToUpper().Substring(2), piElementCategoryWebIdInfo.Path);
            Assert.AreEqual(piElementCategory.Id, piElementCategoryWebIdInfo.ObjectID.ToString());


            PIElementTemplate piElementTemplate = client.ElementTemplate.GetByPath(Constants.AF_ELEMENT_TEMPLATE_PATH, null, webIdType);
            WebIdInfo piElementTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piElementTemplate.WebId);
            Assert.AreEqual(Constants.AF_ELEMENT_TEMPLATE_PATH.ToUpper().Substring(2), piElementTemplateWebIdInfo.Path);
            Assert.AreEqual(piElementTemplate.Id, piElementTemplateWebIdInfo.ObjectID.ToString());


            PIEnumerationSet piEnumerationSet = client.EnumerationSet.GetByPath(Constants.AF_ENUMERATION_SET_PATH, null, webIdType);
            WebIdInfo piEnumerationSetWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationSet.WebId);
            Assert.AreEqual(Constants.AF_ENUMERATION_SET_PATH.ToUpper().Substring(2), piEnumerationSetWebIdInfo.Path);
            Assert.AreEqual(piEnumerationSet.Id, piEnumerationSetWebIdInfo.ObjectID.ToString());


            PIEnumerationValue piEnumerationValue = client.EnumerationValue.GetByPath(Constants.AF_ENUMERATION_VALUE_PATH, null, webIdType);
            WebIdInfo piEnumerationValueWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationValue.WebId);
            Assert.AreEqual(Constants.AF_ENUMERATION_VALUE_PATH.ToUpper().Substring(2), piEnumerationValueWebIdInfo.Path);
            Assert.AreEqual(piEnumerationValue.Id, piEnumerationValueWebIdInfo.ObjectID.ToString());


            PIEventFrame piEventFrame = client.EventFrame.GetByPath(Constants.AF_EVENT_FRAME_PATH, null, webIdType);
            WebIdInfo piEventFrameWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEventFrame.WebId);
            Assert.AreEqual(Constants.AF_EVENT_FRAME_PATH.ToUpper().Substring(2), piEventFrameWebIdInfo.Path);
            Assert.AreEqual(piEventFrame.Id, piEventFrameWebIdInfo.ObjectID.ToString());


            PIPoint piPoint = client.Point.GetByPath(Constants.PI_POINT_PATH, null, webIdType);
            WebIdInfo piPointWebIdInfo = client.WebIdHelper.GetWebIdInfo(piPoint.WebId);
            Assert.AreEqual(Constants.PI_POINT_PATH.ToUpper().Substring(2), piPointWebIdInfo.Path);
            Assert.AreEqual(piPoint.Id.ToString(), piPointWebIdInfo.PointID.ToString());


            PISecurityIdentity piSecurityIdentity = client.SecurityIdentity.GetByPath(Constants.AF_SECURITY_IDENTITY_PATH, null, webIdType);
            WebIdInfo piSecurityIdentityWebIdInfo = client.WebIdHelper.GetWebIdInfo(piSecurityIdentity.WebId);
            Assert.AreEqual(Constants.AF_SECURITY_IDENTITY_PATH.ToUpper().Substring(2), piSecurityIdentityWebIdInfo.Path);
            Assert.AreEqual(piSecurityIdentity.Id, piSecurityIdentityWebIdInfo.ObjectID.ToString());


            PISecurityMapping piSecurityMapping = client.SecurityMapping.GetByPath(Constants.AF_SECURITY_MAPPING_PATH, null, webIdType);
            WebIdInfo piSecurityMappingWebIdInfo = client.WebIdHelper.GetWebIdInfo(piSecurityMapping.WebId);
            Assert.AreEqual(Constants.AF_SECURITY_MAPPING_PATH.ToUpper().Substring(2), piSecurityMappingWebIdInfo.Path);
            Assert.AreEqual(piSecurityMapping.Id, piSecurityMappingWebIdInfo.ObjectID.ToString());


            PITable piTable = client.Table.GetByPath(Constants.AF_TABLE_PATH, null, webIdType);
            WebIdInfo piTableWebIdInfo = client.WebIdHelper.GetWebIdInfo(piTable.WebId);
            Assert.AreEqual(Constants.AF_TABLE_PATH.ToUpper().Substring(2), piTableWebIdInfo.Path);
            Assert.AreEqual(piTable.Id, piTableWebIdInfo.ObjectID.ToString());

            PITableCategory piTableCategory = client.TableCategory.GetByPath(Constants.AF_TABLE_CATEGORY_PATH, null, webIdType);
            WebIdInfo piTableCategoryWebIdInfo = client.WebIdHelper.GetWebIdInfo(piTableCategory.WebId);
            Assert.AreEqual(Constants.AF_TABLE_CATEGORY_PATH.ToUpper().Substring(2), piTableCategoryWebIdInfo.Path);
            Assert.AreEqual(piTableCategory.Id, piTableCategoryWebIdInfo.ObjectID.ToString());


            PIUnit piUnit = client.Unit.GetByPath(Constants.AF_UOM_PATH, null, webIdType);
            WebIdInfo piUnitWebIdInfo = client.WebIdHelper.GetWebIdInfo(piUnit.WebId);
            Assert.AreEqual(Constants.AF_UOM_PATH.ToUpper().Substring(2), piUnitWebIdInfo.Path);
            Assert.AreEqual(piUnit.Id, piUnitWebIdInfo.ObjectID.ToString());


            PIUnitClass piUnitClass = client.UnitClass.GetByPath(Constants.AF_UOM_CLASS_PATH, null, webIdType);
            WebIdInfo piUnitClassWebIdInfo = client.WebIdHelper.GetWebIdInfo(piUnitClass.WebId);
            Assert.AreEqual(Constants.AF_UOM_CLASS_PATH.ToUpper().Substring(2), piUnitClassWebIdInfo.Path);
            Assert.AreEqual(piUnitClass.Id, piUnitClassWebIdInfo.ObjectID.ToString());


        }

        /// <summary>
        /// Test GetWebIDInfo for all types
        /// </summary>
        [Test]
        public void GeneratePathsTest()
        {
            PIAnalysis piAnalysis = client.Analysis.GetByPath(Constants.AF_ANALYSIS_PATH);       
            PIAnalysis piAnalysis2 = client.Analysis.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ANALYSIS_PATH, typeof(PIAnalysis)));
            Assert.AreEqual(piAnalysis.Id, piAnalysis2.Id);


            PIAnalysisCategory piAnalysisCategory = client.AnalysisCategory.GetByPath(Constants.AF_ANALYSIS_CATEGORY_PATH);
            PIAnalysisCategory piAnalysisCategory2 = client.AnalysisCategory.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ANALYSIS_CATEGORY_PATH, typeof(PIAnalysisCategory)));
            Assert.AreEqual(piAnalysisCategory.Id, piAnalysisCategory2.Id);

            PIAnalysisRule piAnalysisRule = client.AnalysisRule.GetByPath(Constants.AF_ANALYSIS_RULE_PATH);
            WebIdInfo piAnalysisRuleWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAnalysisRule.WebId);
            PIAnalysisRule piAnalysisRule2 = client.AnalysisRule.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ANALYSIS_RULE_PATH, typeof(PIAnalysisRule), piAnalysisRuleWebIdInfo.OwnerType));
            Assert.AreEqual(piAnalysisRule.Id, piAnalysisRule2.Id);





            PIAnalysisRulePlugIn piAnalysisRulePlugIn = client.AnalysisRulePlugIn.GetByPath(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH);
            PIAnalysisRulePlugIn piAnalysisRulePlugIn2 = client.AnalysisRulePlugIn.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ANALYSIS_RULE_PLUGIN_PATH, typeof(PIAnalysisRulePlugIn)));
            Assert.AreEqual(piAnalysisRulePlugIn.Id, piAnalysisRulePlugIn2.Id);


            PIAnalysisTemplate piAnalysisTemplate = client.AnalysisTemplate.GetByPath(Constants.AF_ANALYSIS_TEMPLATE_PATH);
            PIAnalysisTemplate piAnalysisTemplate2 = client.AnalysisTemplate.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ANALYSIS_TEMPLATE_PATH, typeof(PIAnalysisTemplate)));
            Assert.AreEqual(piAnalysisTemplate.Id, piAnalysisTemplate2.Id);



            PIAssetDatabase piAssetDatabase = client.AssetDatabase.GetByPath(Constants.AF_DATABASE_PATH);
            PIAssetDatabase piAssetDatabase2 = client.AssetDatabase.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_DATABASE_PATH, typeof(PIAssetDatabase)));
            Assert.AreEqual(piAssetDatabase.Id, piAssetDatabase2.Id);



            PIAssetServer piAssetServer = client.AssetServer.GetByPath(Constants.AF_SERVER_PATH);
            PIAssetServer piAssetServer2 = client.AssetServer.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_SERVER_PATH, typeof(PIAssetServer)));
            Assert.AreEqual(piAnalysisCategory.Id, piAnalysisCategory2.Id);



            PIAttribute piAttribute = client.Attribute.GetByPath(Constants.AF_ATTRIBUTE_PATH);
            WebIdInfo piAttributeWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttribute.WebId);
            PIAttribute piAttribute2 = client.Attribute.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ATTRIBUTE_PATH, typeof(PIAttribute), piAttributeWebIdInfo.OwnerType));
            Assert.AreEqual(piAttribute.Id, piAttribute2.Id);


            PIAttributeCategory piAttributeCategory = client.AttributeCategory.GetByPath(Constants.AF_ATTRIBUTE_CATEGORY_PATH);
            PIAttributeCategory piAttributeCategory2 = client.AttributeCategory.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ATTRIBUTE_CATEGORY_PATH, typeof(PIAttributeCategory)));
            Assert.AreEqual(piAnalysisCategory.Id, piAnalysisCategory2.Id);


            PIAttributeTemplate piAttributeTemplate = client.AttributeTemplate.GetByPath(Constants.AF_ATTRIBUTE_TEMPLATE_PATH);
            WebIdInfo piAttributeTemplateWebIdInfo = client.WebIdHelper.GetWebIdInfo(piAttributeTemplate.WebId);
            PIAttributeTemplate piAttributeTemplate2 = client.AttributeTemplate.Get(client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ATTRIBUTE_TEMPLATE_PATH, typeof(PIAttributeTemplate), piAttributeTemplateWebIdInfo.OwnerType));
            Assert.AreEqual(piAttributeTemplate.Id, piAttributeTemplate2.Id);
           
            PIDataServer piDataServer = client.DataServer.GetByPath(Constants.PI_DATA_SERVER_PATH);
            PIDataServer piDataServer2 = client.DataServer.Get(
                  client.WebIdHelper.GenerateWebIdByPath(Constants.PI_DATA_SERVER_PATH, typeof(PIDataServer)));
            Assert.AreEqual(piDataServer.Id, piDataServer2.Id);

            PIElement piElement = client.Element.GetByPath(Constants.AF_ELEMENT_PATH);
            PIElement piElement2 = client.Element.Get(
                  client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ELEMENT_PATH, typeof(PIElement)));
            Assert.AreEqual(piElement.Id, piElement2.Id);


            PIElementCategory piElementCategory = client.ElementCategory.GetByPath(Constants.AF_ELEMENT_CATEGORY_PATH);
            PIElementCategory piElementCategory2 = client.ElementCategory.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ELEMENT_CATEGORY_PATH, typeof(PIElementCategory)));
            Assert.AreEqual(piAnalysisCategory.Id, piAnalysisCategory2.Id);

            PIElementTemplate piElementTemplate = client.ElementTemplate.GetByPath(Constants.AF_ELEMENT_TEMPLATE_PATH);
            PIElementTemplate piElementTemplate2 = client.ElementTemplate.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ELEMENT_TEMPLATE_PATH, typeof(PIElementTemplate)));
            Assert.AreEqual(piAnalysisCategory.Id, piAnalysisCategory2.Id);


            PIEnumerationSet piEnumerationSet = client.EnumerationSet.GetByPath(Constants.AF_ENUMERATION_SET_PATH);
            WebIdInfo piEnumerationSetWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationSet.WebId);
            PIEnumerationSet piEnumerationSet2 = client.EnumerationSet.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ENUMERATION_SET_PATH, typeof(PIEnumerationSet), piEnumerationSetWebIdInfo.OwnerType));
            Assert.AreEqual(piEnumerationSet.Id, piEnumerationSet2.Id);

            PIEnumerationValue piEnumerationValue = client.EnumerationValue.GetByPath(Constants.AF_ENUMERATION_VALUE_PATH);
            WebIdInfo piEnumerationValueWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEnumerationValue.WebId);
            PIEnumerationValue piEnumerationValue2 = client.EnumerationValue.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_ENUMERATION_VALUE_PATH, typeof(PIEnumerationValue), piEnumerationValueWebIdInfo.OwnerType));
            Assert.AreEqual(piEnumerationValue.Id, piEnumerationValue2.Id);

            //AFEventFrame ev = AFObject.FindObject(Constants.AF_EVENT_FRAME_PATH) as AFEventFrame;
            //string webId33 = ev.GetWebID(WebIDType.PathOnly);
            //PIEventFrame piEventFrame = client.EventFrame.GetByPath(Constants.AF_EVENT_FRAME_PATH);
            //WebIdInfo piEventFrameWebIdInfo = client.WebIdHelper.GetWebIdInfo(piEventFrame.WebId);
            //PIEventFrame piEventFrame2 = client.EventFrame.Get(
            //    client.WebIdHelper.GenerateWebIdByPath(Constants.AF_EVENT_FRAME_PATH, typeof(PIEventFrame)));
            //Assert.AreEqual(piEventFrame.Id, piEventFrame2.Id);

            PIPoint piPoint = client.Point.GetByPath(Constants.PI_POINT_PATH);
            PIPoint piPoint2 = client.Point.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.PI_POINT_PATH, typeof(PIPoint)));
            Assert.AreEqual(piPoint.Id, piPoint2.Id);


            PISecurityIdentity piSecurityIdentity = client.SecurityIdentity.GetByPath(Constants.AF_SECURITY_IDENTITY_PATH);
            PISecurityIdentity piSecurityIdentity2 = client.SecurityIdentity.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_SECURITY_IDENTITY_PATH, typeof(PISecurityIdentity)));
            Assert.AreEqual(piSecurityIdentity.Id, piSecurityIdentity2.Id);


            PISecurityMapping piSecurityMapping = client.SecurityMapping.GetByPath(Constants.AF_SECURITY_MAPPING_PATH);
            PISecurityMapping piSecurityMapping2 = client.SecurityMapping.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_SECURITY_MAPPING_PATH, typeof(PISecurityMapping)));
            Assert.AreEqual(piSecurityMapping.Id, piSecurityMapping2.Id);

            PITable piTable = client.Table.GetByPath(Constants.AF_TABLE_PATH);
            PITable piTable2 = client.Table.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_TABLE_PATH, typeof(PITable)));
            Assert.AreEqual(piTable.Id, piTable2.Id);

            PITableCategory piTableCategory = client.TableCategory.GetByPath(Constants.AF_TABLE_CATEGORY_PATH);
            PITableCategory piTableCategory2 = client.TableCategory.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_TABLE_CATEGORY_PATH, typeof(PITableCategory)));
            Assert.AreEqual(piTableCategory.Id, piTableCategory2.Id);


            PIUnit piUnit = client.Unit.GetByPath(Constants.AF_UOM_PATH);
            PIUnit piUnit2 = client.Unit.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_UOM_PATH, typeof(PIUnit)));
            Assert.AreEqual(piUnit.Id, piUnit2.Id);
            
            PIUnitClass piUnitClass = client.UnitClass.GetByPath(Constants.AF_UOM_CLASS_PATH);
            PIUnitClass piUnitClass2 = client.UnitClass.Get(
                client.WebIdHelper.GenerateWebIdByPath(Constants.AF_UOM_CLASS_PATH, typeof(PIUnitClass)));
            Assert.AreEqual(piUnitClass.Id, piUnitClass2.Id);


        }

    }
}
