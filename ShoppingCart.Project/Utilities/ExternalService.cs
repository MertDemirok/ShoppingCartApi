using System;
using Newtonsoft.Json;
using RestSharp;

namespace ShoppingCart.Project.Utilities
{
    public class ExternalService : IExternalService
    {

        public T BasicJsonRequest<T>(string baseUrl, string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, DataFormat.Json);
            var response = client.Get(request);

        
          return  JsonConvert.DeserializeObject<T>(response.Content);

        }
 
    }
}
