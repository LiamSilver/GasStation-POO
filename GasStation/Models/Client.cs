using System.DirectoryServices;
using System.Net.Mail;
namespace GasStation.Models
{
    public class Client
    {

        public Client()
        {
        }
        #region attributes
        public string name { get; private set; }

        public string cpf { get; private set; }
        public string? phone { get; private set; }

        public string? phone2 { get; private set; }

        public Address address { get; private set; }
        

        #endregion

        #region methods

        public void setName(string name)
        {
            this.name = name;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public void setPhone2(string phone)
        {
            this.phone2 = phone;
        }

        public void setAddress(Address address)
        {
            this.address = address;
        }
        #endregion
    }
}
