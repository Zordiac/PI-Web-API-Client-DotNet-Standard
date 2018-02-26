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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIsoft.PIDevClub.PIWebApiClient.WebID
{
    public class WebIdInfo
    {
        private enum WebIdStringType { OneGuid, TwoGuids, ThreeGuids }
        public Type ObjectType { get; private set; }
        public Type OwnerType { get; private set; }
        public Guid ServerID { get; private set; }
        public Guid ObjectID { get; private set; }
        public Guid OwnerID { get; private set; }
        public int PointID { get; private set; }
        public string Path { get; private set; }
        public WebIdType WebIdType { get; private set; }
        public int Version { get; private set; }
        public string Marker { get; private set; }

        internal WebIdInfo(string webId)
        {
            WebIdType = GetWebIdType(webId);
            if ((WebIdType == WebIdType.DefaultIDOnly) || (WebIdType == WebIdType.LocalIDOnly))
            {
                throw new WebIdException("This library is not compatible with DefaultIDOnly or LocalIDOnly. Use Full, PathOnly or IDOnly instead.");
            }
            Version = Convert.ToInt32(webId.Substring(1, 1));
            if (Version == 0)
            {
                throw new WebIdException("This tool is compatible with Web ID 2.0 only. The second character of the Web ID must be 1.");
            }

            ProcessType(webId);
            ProcessGuidsAndPaths(webId);
        }

        private WebIdType GetWebIdType(string webId)
        {
            string webIdTypeLetter = webId.Substring(0, 1);
            if (webIdTypeLetter == "F")
            {
                return WebIdType.Full;
            }
            else if (webIdTypeLetter == "I")
            {
                return WebIdType.IDOnly;
            }
            else if (webIdTypeLetter == "P")
            {
                return WebIdType.PathOnly;
            }
            else if (webIdTypeLetter == "L")
            {
                return WebIdType.LocalIDOnly;
            }
            else if (webIdTypeLetter == "D")
            {
                return WebIdType.DefaultIDOnly;
            }
            throw new WebIdException("Incorrect Web ID type (first letter).");
        }

        private void ProcessType(string webId)
        {
            Marker = webId.Substring(2, 2);
            if (Marker == "Xs")
            {
                ObjectType = typeof(PIAnalysis);
            }
            else if (Marker == "XC")
            {
                ObjectType = typeof(PIAnalysisCategory);
            }
            else if (Marker == "XT")
            {
                ObjectType = typeof(PIAnalysisTemplate);
            }
            else if (Marker == "XR")
            {
                ObjectType = typeof(PIAnalysisRule);
            }
            else if (Marker == "XP")
            {
                ObjectType = typeof(PIAnalysisRulePlugIn);
            }
            else if (Marker == "Ab")
            {
                ObjectType = typeof(PIAttribute);
            }
            else if (Marker == "AC")
            {
                ObjectType = typeof(PIAttributeCategory);
            }
            else if (Marker == "AT")
            {
                ObjectType = typeof(PIAttributeTemplate);
            }
            else if (Marker == "RD")
            {
                ObjectType = typeof(PIAssetDatabase);
            }
            else if (Marker == "Em")
            {
                ObjectType = typeof(PIElement);
            }
            else if (Marker == "EC")
            {
                ObjectType = typeof(PIElementCategory);
            }
            else if (Marker == "ET")
            {
                ObjectType = typeof(PIElementTemplate);
            }
            else if (Marker == "MS")
            {
                ObjectType = typeof(PIEnumerationSet);
            }
            else if (Marker == "MV")
            {
                ObjectType = typeof(PIEnumerationValue);
            }
            else if (Marker == "Fm")
            {
                ObjectType = typeof(PIEventFrame);
            }
            else if (Marker == "TR")
            {
                ObjectType = typeof(PITimeRule);
            }
            else if (Marker == "TP")
            {
                ObjectType = typeof(PITimeRulePlugIn);
            }
            else if (Marker == "SI")
            {
                ObjectType = typeof(PISecurityIdentity);
            }
            else if (Marker == "SM")
            {
                ObjectType = typeof(PISecurityMapping);
            }
            else if (Marker == "Bl")
            {
                ObjectType = typeof(PITable);
            }
            else if (Marker == "BC")
            {
                ObjectType = typeof(PITableCategory);
            }
            else if (Marker == "DP")
            {
                ObjectType = typeof(PIPoint);
            }
            else if (Marker == "DS")
            {
                ObjectType = typeof(PIDataServer);
            }
            else if (Marker == "RS")
            {
                ObjectType = typeof(PIAssetServer);
            }
            else if (Marker == "Ut")
            {
                ObjectType = typeof(PIUnit);
            }
            else if (Marker == "UC")
            {
                ObjectType = typeof(PIUnitClass);
            }
        }

        private void ProcessOwnerType(string markerOwner)
        {
            if (markerOwner == "R")
            {
                OwnerType = typeof(PIAssetServer);
            }
            else if (markerOwner == "D")
            {
                OwnerType = typeof(PIDataServer);
            }
            else if (markerOwner == "X")
            {
                OwnerType = typeof(PIAnalysis);
            }
            else if (markerOwner == "T")
            {
                OwnerType = typeof(PIAnalysisTemplate);
            }
            else if (markerOwner == "E")
            {
                OwnerType = typeof(PIElement);
            }
            else if (markerOwner == "F")
            {
                OwnerType = typeof(PIEventFrame);
            }
        }

        private void ProcessGuidsAndPaths(string webId)
        {
            if (ObjectType == typeof(PIAnalysis))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIAnalysisCategory))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIAnalysisTemplate))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIAnalysisRule))
            {
                ProcessGuidsAndPaths(webId, true, WebIdStringType.ThreeGuids, false);
            }
            else if (ObjectType == typeof(PIAnalysisRulePlugIn))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIAttribute))
            {
                ProcessGuidsAndPaths(webId, true, WebIdStringType.ThreeGuids, false);
            }
            else if (ObjectType == typeof(PIAttributeCategory))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIAttributeTemplate))
            {
                ProcessGuidsAndPaths(webId, true, WebIdStringType.ThreeGuids, false);
                OwnerType = typeof(PIElementTemplate);
            }
            else if (ObjectType == typeof(PIAssetDatabase))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIElement))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIElementCategory))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIElementTemplate))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIEnumerationSet))
            {
                ProcessGuidsAndPaths(webId, true, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIEnumerationValue))
            {
                ProcessGuidsAndPaths(webId, true, WebIdStringType.ThreeGuids, false);
            }
            else if (ObjectType == typeof(PIEventFrame))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PITimeRule))
            {
                ProcessGuidsAndPaths(webId, true, WebIdStringType.ThreeGuids, false);
            }
            else if (ObjectType == typeof(PITimeRulePlugIn))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PISecurityIdentity))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PISecurityMapping))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PITable))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PITableCategory))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIPoint))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, true);
            }
            else if (ObjectType == typeof(PIDataServer))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.OneGuid, false);
            }
            else if (ObjectType == typeof(PIAssetServer))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.OneGuid, false);
            }
            else if (ObjectType == typeof(PIUnit))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
            else if (ObjectType == typeof(PIUnitClass))
            {
                ProcessGuidsAndPaths(webId, false, WebIdStringType.TwoGuids, false);
            }
        }



        private void ProcessGuidsAndPaths(string webId, bool hasMarkerOwner, WebIdStringType webIdStringType, bool usePIPoint = false)
        {
            string restWebId = webId.Substring(4);

            if (hasMarkerOwner == true)
            {
                string markerOwner = restWebId.Substring(0, 1);
                ProcessOwnerType(markerOwner);
                restWebId = restWebId.Substring(1);
            }

            if ((WebIdType == WebIdType.Full) || (WebIdType == WebIdType.IDOnly))
            {
                string encodedServerID = restWebId.Substring(0, 22);
                ServerID = DecodeGUID(encodedServerID);
                restWebId = restWebId.Substring(22);

                if (webIdStringType == WebIdStringType.ThreeGuids)
                {
                    string encodedOwnerID = restWebId.Substring(0, 22);
                    OwnerID = DecodeGUID(encodedOwnerID);
                    restWebId = restWebId.Substring(22);
                }
                if ((webIdStringType == WebIdStringType.ThreeGuids) ||
                    (webIdStringType == WebIdStringType.TwoGuids))
                {

                    if (usePIPoint == false)
                    {
                        string encodedObjectID = restWebId.Substring(0, 22);
                        ObjectID = DecodeGUID(encodedObjectID);
                        restWebId = restWebId.Substring(22);
                    }
                    else
                    {
                        string encodedObjectID = restWebId.Substring(0, 6);
                        PointID = DecodeInt(encodedObjectID);
                        restWebId = restWebId.Substring(6);
                    }

                }
            }

            if ((WebIdType == WebIdType.Full) || (WebIdType == WebIdType.PathOnly))
            {
                string encodedPath = restWebId;
                Path = DecodeString(encodedPath);
            }
        }

        internal static byte[] Decode(string value)
        {
            //Base 64 strings are in multiples of 4 bytes long.  
            //This restores the = sign padding and changes the Uri-safe chars with the Base64 requirement  
            StringBuilder decodestring = new StringBuilder(value.Replace('-', '+').Replace('_', '/'));
            int padneeded = (4 - (value.Length % 4)) % 4;

            for (int i = 0; i < padneeded; i++)
            {
                decodestring.Append('=');
            }

            byte[] bytes = System.Convert.FromBase64String(decodestring.ToString());
            return bytes;
        }

        internal static string DecodeString(string value)
        {
            return Encoding.UTF8.GetString(Decode(value));
        }

        internal static int DecodeInt(string input)
        {
            byte[] bytes = Decode(input);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return BitConverter.ToInt32(bytes, 0);
        }

        internal static Guid DecodeGUID(string value)
        {
            byte[] guid = Decode(value);
            return new Guid(guid);
        }

    }
}
