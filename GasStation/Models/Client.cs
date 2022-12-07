using System.DirectoryServices;
using System.Net.Mail;
namespace GasStation.Models
{
    public class Client
    {
        #region attributes
        private string _name;
        private string _cpf;
        private string? _phone;
        private string? _phone2;
        private Address? _address;
        #endregion

        #region properties
        public string name { get { return _name; }
            private set {
                if (value == null || value == "") throw new ArgumentNullException(null, "O nome não pode ser nulo ");
                if (value.Length <= 2) throw new ArgumentOutOfRangeException(null, "Nome pequeno demais");
                _name = value.ToUpper();
            }
        }

        public string cpf { get { return _cpf; }
            private set {
                if (value.Length != 11) throw new ArgumentOutOfRangeException(null,"Digite todo o CPF");
                else _cpf = value;
            }
        }
        public string? phone { get { return _phone; }
            private set
            {
                _phone = value;
            }
        } 

        public string? phone2 { get { return _phone2; }
            private set 
            {
                _phone2 = value;
            }
        }

        public Address address { get { return _address; }
            private set 
            {
                _address = value;
            }
        }


        #endregion

        #region Constructors

        public Client(string name, string cpf, string? phone, string? phone2, Address? address)
        {
            this.name = name;
            this.cpf = cpf;
            this.phone = phone;
            this.phone2 = phone2;
            this.address = address;
        }
        public Client()
        {
        }
        public Client(string name, string cpf, string? phone, string? phone2)
        {
            this.name = name;
            this.cpf = cpf;
            this.phone = phone;
            this.phone2 = phone2;

        }

        public Client (Address address)
        {
            this.address = address;
        }
        #endregion
        #region methods

        #endregion
    }
}
