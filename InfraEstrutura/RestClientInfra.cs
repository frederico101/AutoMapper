using System.Net.Http;
using Mapper;
using Mapper.Interfaces;
using Newtonsoft.Json;
using RestSharp;

namespace InfraEstrutura
{
    public class RestClientInfra : IClient
    {
        public Client GetClient()
        {
            var client = new RestClient("https://c05929e6-75be-4d46-b491-770b16952fe2.mock.pstmn.io/");

            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new System.Exception("erro");
            return JsonConvert.DeserializeObject<Client>(response.Content);


        }
    }
}