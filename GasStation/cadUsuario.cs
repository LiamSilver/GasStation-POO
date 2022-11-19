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
    public partial class cadUsuario : Form
    {
        public cadUsuario()
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
            address.cep = mtxbZipCode.Text.ToUpper();
            address.bairro = txbNeighbourhood.Text.ToUpper();
            address.localidade = txbCity.Text.ToUpper();
            address.uf = cbxState.Text.ToUpper();
            address.logradouro = txbStreet.Text.ToUpper();
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

            cleanFields();
            txbName.Focus();

        }

        private void addClient()
        {
            try
            {
                Address address = new();
                address = getAddress(address);

                Client client = new();
                client = getClient(client, address);

                string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;

                UserDAL DAL = new(new SqlConnection(connectionString));

                DAL.Inserir(client);

                MessageBox.Show("Cadastro realizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanFields()
        {
            txbCity.Text = "";
            txbName.Text = "";
            txbNeighbourhood.Text = "";
            txbStreet.Text = "";
            mtxbCpf.Text = "";
            mtxbPhone.Text = "";
            mtxbPhone2.Text = "";
            mtxbZipCode.Text = "";
            cbxState.Text = "";
        }
    }
}
