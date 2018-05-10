using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace OSIsoft.PIDevClub.PIWebApiClient.Client
{
    public interface IRestResponse
    {
        bool IsSuccessful { get; }
        HttpStatusCode StatusCode { get; }
        HttpContent Content { get; }
        string StatusDescription { get; }
        Version ProtocolVersion { get; }
        HttpResponseHeaders Headers { get; }
        string StringContent { get; }

        dynamic JsonContent { get; }
    }
}
