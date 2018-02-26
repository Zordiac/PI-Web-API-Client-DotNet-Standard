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

using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System;
using System.Text;

namespace OSIsoft.PIDevClub.PIWebApiClient.WebID
{
    public interface IWebIdHelper
    {
        WebIdInfo GetWebIdInfo(string webId);
        string GenerateWebIdByPath(string path, Type type, Type ownerType = null);
    }

    public class WebIdHelper : IWebIdHelper
    {
        public WebIdInfo GetWebIdInfo(string webId)
        {
            return new WebIdInfo(webId);
        }

        public string GenerateWebIdByPath(string path, Type type, Type ownerType = null)
        {
            ValidateTypeAndOwnerType(type, ownerType);
            string marker = GetMarker(type);
            string ownerMarker = GetOwnerMarker(ownerType);

            if (path.Substring(0, 2) == "\\\\")
            {
                path = path.Substring(2);
            }
            string encodedPath = Encode(path.ToUpperInvariant());
            return string.Format("P1{0}{1}{2}", marker, ownerMarker, encodedPath);
        }

        private void ValidateTypeAndOwnerType(Type type, Type ownerType)
        {
            if (type == typeof(PIAttribute))
            {
                if ((ownerType != typeof(PIElement)) && (ownerType != typeof(PIEventFrame)))
                {
                    throw new WebIdException("PIAttribte owner type must be a PIElement or a PIEventFrame.");
                }
            }
            else if (type == typeof(PIAttributeTemplate))
            {
                if ((ownerType != typeof(PIElementTemplate)))
                {
                    throw new WebIdException("PIElementTemplate owner type must be a PIElementTemplate.");
                }
            }
            else if ((type == typeof(PIEnumerationSet)) && (type == typeof(PIEnumerationValue)))
            {
                if ((ownerType != typeof(PIDataServer)) && (ownerType != typeof(PIAssetServer)))
                {
                    throw new WebIdException("PIEnumerationSet and  PIEnumerationValue owner type must be a PIDataServer or PIAssetServer.");
                }
            }
            else if (type == typeof(PITimeRule))
            {
                if ((ownerType != typeof(PIAnalysis)) && (ownerType != typeof(PIAnalysisTemplate)))
                {
                    throw new WebIdException("PITimeRule owner type must be a PIAnalysis and PIAnalysisTemplate.");
                }
            }
        }

        private string GetOwnerMarker(Type ownerType)
        {
            string markerOwner = string.Empty;
            if (ownerType == null)
            {
                return markerOwner;
            }

            if (ownerType == typeof(PIAssetServer))
            {
                markerOwner = "R";
            }
            else if (ownerType == typeof(PIDataServer))
            {
                markerOwner = "D";
            }
            else if (ownerType == typeof(PIAnalysis))
            {
                markerOwner = "X";
            }
            else if (ownerType == typeof(PIAnalysisTemplate))
            {
                markerOwner = "T";
            }
            else if (ownerType == typeof(PIElement))
            {
                markerOwner = "E";
            }
            if (ownerType == typeof(PIElementTemplate))
            {
                markerOwner = "E";
            }
            else if (ownerType == typeof(PIEventFrame))
            {
                markerOwner = "F";
            }
            return markerOwner;
        }

        private string GetMarker(Type type)
        {
            string marker = string.Empty;
            if (type == typeof(PIAnalysis))
            {
                marker = "Xs";
            }
            else if (type == typeof(PIAnalysisCategory))
            {
                marker = "XC";
            }
            else if (type == typeof(PIAnalysisTemplate))
            {
                marker = "XT";
            }
            else if (type == typeof(PIAnalysisRule))
            {
                marker = "XR";
            }
            else if (type == typeof(PIAnalysisRulePlugIn))
            {
                marker = "XP";
            }
            else if (type == typeof(PIAttribute))
            {
                marker = "Ab";
            }
            else if (type == typeof(PIAttributeCategory))
            {
                marker = "AC";
            }
            else if (type == typeof(PIAttributeTemplate))
            {
                marker = "AT";
            }
            else if (type == typeof(PIAssetDatabase))
            {
                marker = "RD";
            }
            else if (type == typeof(PIAssetServer))
            {
                marker = "RS";
            }
            else if (type == typeof(PIElement))
            {
                marker = "Em";
            }
            else if (type == typeof(PIElementCategory))
            {
                marker = "EC";
            }
            else if (type == typeof(PIElementTemplate))
            {
                marker = "ET";
            }
            else if (type == typeof(PIEnumerationSet))
            {
                marker = "MS";
            }
            else if (type == typeof(PIEnumerationValue))
            {
                marker = "MV";
            }
            else if (type == typeof(PIEventFrame))
            {
                marker = "Fm";
            }
            else if (type == typeof(PITimeRule))
            {
                marker = "TR";
            }
            else if (type == typeof(PITimeRulePlugIn))
            {
                marker = "TP";
            }
            else if (type == typeof(PISecurityIdentity))
            {
                marker = "SI";
            }
            else if (type == typeof(PISecurityMapping))
            {
                marker = "SM";
            }
            else if (type == typeof(PITable))
            {
                marker = "Bl";
            }
            else if (type == typeof(PITableCategory))
            {
                marker = "BC";
            }
            else if (type == typeof(PIPoint))
            {
                marker = "DP";
            }
            else if (type == typeof(PIDataServer))
            {
                marker = "DS";
            }
            else if (type == typeof(PIUnit))
            {
                marker = "Ut";
            }
            else if (type == typeof(PIUnitClass))
            {
                marker = "UC";
            }
            if (string.IsNullOrEmpty(marker) == true)
            {
                throw new WebIdException("Invalid object type.");
            }
            return marker;
        }

        internal static string Encode(string value)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(value.ToUpperInvariant());
            return Encode(bytes);
        }

        internal static string Encode(byte[] value)
        {
            string encoded = System.Convert.ToBase64String(value);
            return encoded.TrimEnd(new char[] { '=' }).Replace('+', '-').Replace('/', '_');
        }

        internal static string Encode(Guid value)
        {
            byte[] bytes = value.ToByteArray();
            return Encode(bytes);
        }
    } 
}