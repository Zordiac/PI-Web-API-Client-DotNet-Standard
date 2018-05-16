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

using OSIsoft.PIDevClub.PIWebApiClient.Api;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using OSIsoft.PIDevClub.PIWebApiClient.WebID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIsoft.PIDevClub.PIWebApiClient
{


    public class PIWebApiClient
    {
        private ApiClient client = null;
        public string BaseUrl { get; private set; }
        public bool UseKerberos { get; private set; }
        public string UserName { get; private set; }

        private string Password;


        public PIWebApiClient(string baseUrl, bool useKerberos = true, string username = null, string password = null)
        {
            if (baseUrl.Last() == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }

            UseKerberos = useKerberos;
            UserName = username;
            Password = password;
            client = new ApiClient(baseUrl, useKerberos, username, password);

        }

        private Configuration GetConfiguration(bool NoCacheHeaderCompatible)
        {
            Configuration config = new Configuration(client);
            if (NoCacheHeaderCompatible == true)
            {
                config.DefaultHeader.Add("Cache-Control", "no-cache");
            }
            return config;
        }


        public IAnalysisApi Analysis
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisApi(config);
            }
        }

        public IAnalysisCategoryApi AnalysisCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisCategoryApi(config);
            }
        }

        public IAnalysisRulePlugInApi AnalysisRulePlugIn
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisRulePlugInApi(config);
            }
        }

        public IAnalysisRuleApi AnalysisRule
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisRuleApi(config);
            }
        }

        public IAnalysisTemplateApi AnalysisTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AnalysisTemplateApi(config);
            }
        }

        public IAssetDatabaseApi AssetDatabase
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AssetDatabaseApi(config);
            }
        }

        public IAssetServerApi AssetServer
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AssetServerApi(config);
            }
        }

        public IAttributeApi Attribute
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeApi(config);
            }
        }

        public IAttributeCategoryApi AttributeCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeCategoryApi(config);
            }
        }

        public IAttributeTemplateApi AttributeTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeTemplateApi(config);
            }
        }

        public IAttributeTraitApi AttributeTrait
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new AttributeTraitApi(config);
            }
        }

        public IBatchApi BatchApi
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new BatchApi(config);
            }
        }

        public ICalculationApi Calculation
        {
            get
            {
                Configuration config = GetConfiguration(false);
                return new CalculationApi(config);
            }
        }

        public IConfigurationApi Configuration
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ConfigurationApi(config);
            }
        }

        public IChannelApi Channel
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ChannelApi(config);
            }
        }

        public IDataServerApi DataServer
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new DataServerApi(config);
            }
        }

        public IElementApi Element
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ElementApi(config);
            }
        }

        public IElementCategoryApi ElementCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ElementCategoryApi(config);
            }
        }



        public IElementTemplateApi ElementTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new ElementTemplateApi(config);
            }
        }


        public IEnumerationSetApi EnumerationSet
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new EnumerationSetApi(config);
            }
        }


        public IEnumerationValueApi EnumerationValue
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new EnumerationValueApi(config);
            }
        }

        public IEventFrameApi EventFrame
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new EventFrameApi(config);
            }
        }


        public IHomeApi Home
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new HomeApi(config);
            }
        }

        public INotificationContactTemplateApi NotificationContactTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationContactTemplateApi(config);
            }
        }

        public INotificationRuleApi NotificationRule
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationRuleApi(config);
            }
        }

        public INotificationRuleSubscriberApi NotificationRuleSubscriber
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationRuleSubscriberApi(config);
            }
        }

        public INotificationRuleTemplateApi NotificationRuleTemplate
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new NotificationRuleTemplateApi(config);
            }
        }


        public IPointApi Point
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new PointApi(config);
            }
        }


        public ISecurityIdentityApi SecurityIdentity
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new SecurityIdentityApi(config);
            }
        }

        public ISecurityMappingApi SecurityMapping
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new SecurityMappingApi(config);
            }
        }

        public IStreamApi Stream
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new StreamApi(config);
            }
        }

        public IStreamSetApi StreamSet
        {
            get
            {
                Configuration config = GetConfiguration(false);
                return new StreamSetApi(config);
            }
        }


        public ISystemApi System
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new SystemApi(config);
            }
        }

        public ITableApi Table
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TableApi(config);
            }
        }

        public ITableCategoryApi TableCategory
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TableCategoryApi(config);
            }
        }

        public ITimeRuleApi TimeRule
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TimeRuleApi(config);
            }
        }

        public ITimeRulePlugInApi TimeRulePlugIn
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new TimeRulePlugInApi(config);
            }
        }

        public IUnitApi Unit
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new UnitApi(config);
            }
        }
        public IUnitClassApi UnitClass
        {
            get
            {
                Configuration config = GetConfiguration(true);
                return new UnitClassApi(config);
            }
        }

        public IWebIdHelper WebIdHelper
        {
            get
            {
                PISystemLanding systemLanding = null;
                if (systemLanding == null)
                {
                    systemLanding = System.Landing();
                }
                int piWebApiYearVersion = Convert.ToInt32(systemLanding.ProductTitle.Substring(11, 4));
                if ((systemLanding.ProductVersion == "1.9.0.266") || (piWebApiYearVersion < 2017))
                {
                    throw new WebIdException("This PI Web API version is not compatible with Web ID 2.0. Please update your PI Web API to 2017 R2 to use this feature.");
                }
                return new WebIdHelper();
            }
        }
    }
}
