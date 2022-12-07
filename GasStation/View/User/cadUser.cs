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

        #region utils

        private void mtxbZipCode_Leave(object sender, EventArgs e)
        {
            if (mtxbZipCode.Text.Length == 8)
            {
                //Address? address = new(mtxbZipCode.Text);

                try
                {
                    Address? address = new(mtxbZipCode.Text);
                    address = address.cepSearch(address.cep);
                    if (address.cep!=null)
                        dataFoundZipCode(address);
                    else
                    {
                        MessageBox.Show("CEP não encontrado", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        mtxbZipCode.Text = "";
                        mtxbZipCode.Focus();
                        cleanAdress();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Aviso",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cleanFields()
        {
            cleanAdress();
            txbName.Text = "";
            mtxbCpf.Text = "";
            mtxbPhone.Text = "";
            mtxbPhone2.Text = "";
            mtxbZipCode.Text = "";
            cbxState.Text = "";
        }

        #endregion


        #region Insert
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                addClient();
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
            if (DAL.checkCpfExistence(client.cpf) == false)
            {
                DAL.Insert(client);
                MessageBox.Show("Cadastro realizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanFields();
            }
        }

        private Client getData()
        {
            Client client = new();
            try
            {
                Address address = new(mtxbZipCode.Text, txbCity.Text, txbNeighbourhood.Text, txbStreet.Text, cbxState.Text);
                client = new(txbName.Text, mtxbCpf.Text, mtxbPhone.Text, mtxbPhone2.Text,address);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return client;
        }

        #endregion
    }
}
