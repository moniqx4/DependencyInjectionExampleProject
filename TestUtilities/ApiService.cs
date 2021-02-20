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

        //example way to handle data received, change T to the actual type(model) of the API response and then parse that data to a list or array
        //public T GetByPageGroupId(string number)
        //{
        //    var elements = GetApiResponse(apiEndpoint);
        //    return elements.FirstOrDefault(element => element.locator == Elementlocator);
        }
    }

    public delegate void T();

