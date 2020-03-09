using Interfaces;
using Mapper.Entity;
using Newtonsoft.Json;
using RestSharp;

namespace InfraEstrutura
{
    public class RestClient01Infra : IClient01
    {
        public Client01 GetClient01()
        {
            var client = new RestClient("https://403b46d2-9536-475e-a219-fd0e996edb84.mock.pstmn.io/");

            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                throw new System.Exception("erro");
            return JsonConvert.DeserializeObject<Client01>(response.Content);
        }
    }
}