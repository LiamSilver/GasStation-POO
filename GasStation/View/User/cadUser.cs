using GasStation.Models;
using GasStation.Persistence.DAL;
using RestSharp;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GasStation
{
    public partial class cadUser : Form
    {
        public cadUser()
        {
            InitializeComponent();
        }

        private void mtxbZipCode_Leave(object sender, EventArgs e)
        {
            if (mtxbZipCode.Text.Length == 8)
            {
                Address? address =  new();
                address = address.cepSearch(mtxbZipCode.Text);
                if(address.cep != null)
                    dataFoundZipCode(address);
                else { 
                    MessageBox.Show("CEP invalido e/ou não encontrado");
                    mtxbZipCode.Text = "";
                    mtxbZipCode.Focus();
                    cleanAdress();
                }
            }

        }



        private void dataFoundZipCode(Address address)
        {
            txbStreet.Text = address.logradouro;
            txbNeighbourhood.Text = address.bairro;
            txbCity.Text = address.localidade;
            cbxState.Text = address.uf;
        }
        

        private void cleanAdress()
        {
            txbCity.Text = "";
            txbNeighbourhood.Text = "";
            txbStreet.Text = "";
            cbxState.Text = "";
        }

        private Address getAddress(Address address)
        {
            address.setCep(mtxbZipCode.Text);
            address.setNeighbourhood(txbNeighbourhood.Text);
            address.setCity(txbCity.Text);
            address.setState(cbxState.Text);
            address.setStreet(txbStreet.Text);
            return address;
        }

        private Client getClient(Client client, Address address)
        {
            client.setName(txbName.Text.ToUpper());
            client.setCpf(mtxbCpf.Text.ToUpper());
            client.setPhone(mtxbPhone.Text.ToUpper());
            client.setPhone2(mtxbPhone2.Text.ToUpper());
            client.setAddress(address);

            return client;
        }

        private bool hasNameAndCpf()
        {
            if(txbName.Text.Trim().Length<=0 || mtxbCpf.MaskFull is false)
            {
                return false;
            }
            return true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(hasNameAndCpf()==true)
            {
                addClient();

            }
            else
            {
                MessageBox.Show("Nome ou CPF não preenchidos","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbName.Focus();
                return;
            }
            txbName.Focus();


        }

        private void addClient()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;

                UserDAL DAL = new(new SqlConnection(connectionString));

                Client client = getData();

                addUser(DAL, client);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível realizar o cadastro! \nMotivo do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addUser(UserDAL DAL, Client client)
        {
            if (DAL.checkCpfExistence(client.cpf) == false && client.fieldsIsCompleted(client) == true)
            {
                DAL.Insert(client);

                MessageBox.Show("Cadastro realizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanFields();
            }
        }

        private Client getData()
        {
            Address address = new();
            address = getAddress(address);

            Client client = new();
            client = getClient(client, address);
            return client;
        }

        private void cleanFields()
        {
            cleanAdress();
            mtxbCpf.Text = "";
            mtxbPhone.Text = "";
            mtxbPhone2.Text = "";
            mtxbZipCode.Text = "";
            cbxState.Text = "";
        }
    }
}
