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

namespace LibraryTest
{
    public class CustomChannelObserver : IObserver<PIItemsStreamValues>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Completed");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public void OnNext(PIItemsStreamValues value)
        {
            foreach(PIStreamValues item in value.Items)
            {
                foreach (PITimedValue subItem in item.Items)
                {
                    Console.WriteLine("\n\nName={0}, Path={1}, WebId={2}, Value={3}, Timestamp={4}", item.Name, item.Path, item.WebId, subItem.Value, subItem.Timestamp);
                }
            }
            Console.Write(value.Items[0].Items[0].Value);
        }
    }
}

