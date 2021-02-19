using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace TestUtilities
{
    public class ApiService
    {
        public ApiService()
        {

        }

        public IList<T> GetApiResponse(string apiEndpoint)
        {
            var client = new RestClient(apiEndpoint);
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json
            };

            var response = client.Execute(request);

            if(response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new SystemException("Call to endpoint failed" + response.StatusCode);
            }

            return JsonConvert.DeserializeObject<IList<T>>(response.Content);
        }
    }

    public delegate void T();
}
