using RestSharp;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GasStation.Models
{

    public class Address
    {

        #region attributes
        private string _cep;
        private string? _logradouro;
        private string? _bairro;
        private string? _localidade;
        private string? _uf;
        #endregion

        #region properties
        public string cep { get { return _cep; }
            set
            {
                if (value.Length < 8) throw new ArgumentOutOfRangeException(null, "O cep deve ter 8 números");
                if (value == null) throw new ArgumentNullException(null, "O CEP não pode ser nulo");

                _cep = value;
            }
        }
        public string? logradouro { get { return _logradouro; } set { _logradouro = value.ToUpper(); } }

        public string? bairro { get { return _bairro; } set { _bairro = value.ToUpper(); } }


        public string? localidade { get { return _localidade; } 
             set 
            {
                if (value == null) throw new ArgumentNullException("Digite uma cidade");
                _localidade = value.ToUpper(); 
            } 
        }

        public string? uf { get { return _uf; } 
            set 
            {
                if (value == null) throw new ArgumentNullException(null, "Escolha um Estado");
                _uf = value.ToUpper(); 
            } 
        }
        #endregion

        #region Constructors
        public Address(string zipCode, string? city, string? neighbourhood, string? street, string? uf) {

            cep=zipCode;
            localidade=city;
            logradouro = street;
            bairro = neighbourhood;
            this.uf = uf;
            
        }

        public Address(string zipCode)
        {
            this.cep = zipCode;
        }

        public Address()
        {
        
        }
        #endregion
        #region Methods
        public Address? cepSearch(string cep)
        {
                RestResponse restResponse = zipCodeRestConnection(cep);

            if (restResponse.IsSuccessful)
            {

                Address address = JsonSerializer.Deserialize<Address>(restResponse.Content);
                return address;
            }
            else{
                cep = null;
                throw new Exception("CEP não encontrado");
            }
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
