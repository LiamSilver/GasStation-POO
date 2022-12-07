using RestSharp;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GasStation.Models
{

    public class Address
    {

        #region attributes
        public string cep { get; set; }
        public string? logradouro { get; set; }

        public string bairro { get; set; }
        public string? localidade { get; set; }
        public string uf { get; set; }

        #endregion


        #region Methods
        public Address? cepSearch(string cep)
        {
                RestResponse restResponse = zipCodeRestConnection(cep);

                if (restResponse.IsSuccessful)
                {
                    Address? address = JsonSerializer.Deserialize<Address>(restResponse.Content);
                    return address;
                }
                else
                    return null;
        }
        private RestResponse zipCodeRestConnection(string cep)
        {
            RestClient restClient = new RestClient(string.Format($"https://viacep.com.br/ws/{cep}/json/"));
            RestRequest restRequest = new RestRequest();
            restRequest.Method = Method.Get;

            RestResponse restResponse = restClient.Execute(restRequest);

            return restResponse;

        }
        #endregion

    }
}
