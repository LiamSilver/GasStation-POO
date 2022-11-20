using GasStation.Models;
using GasStation.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace GasStation.View.User
{
    public partial class updateUser : Form
    {
        public updateUser()
        {
            InitializeComponent();
        }

        public void unlockFields()
        {
            if (btnSearch.Text == "Buscar")
            {
                mtxbPhone.Enabled = true;
                mtxbPhone2.Enabled = true;
                txbCity.Enabled = true;
                txbName.Enabled = true;
                txbNeighbourhood.Enabled = true;
                txbStreet.Enabled = true;
                cbxState.Enabled = true;
                mtxbZipCode.Enabled = true;
                btnUpdate.Enabled = true;
                btnSearch.Text = "Cancelar";
                mtxbCpf.Enabled = false;
                txbName.Focus();
            }
            else if(btnSearch.Text == "Cancelar")
            {
                btnUpdate.Enabled = false;
                mtxbPhone.Enabled = false;
                mtxbPhone2.Enabled = false;
                txbCity.Enabled = false;
                txbName.Enabled = false;
                txbNeighbourhood.Enabled = false;
                txbStreet.Enabled = false;
                cbxState.Enabled = false;
                btnSearch.Enabled = false;
                mtxbZipCode.Enabled = false;
                btnSearch.Text = "Buscar";
                mtxbCpf.Enabled = true;
                mtxbCpf.Text = "";
                mtxbCpf.Focus();
                cleanFields();
            }

        }

        public void cleanFields() {
            txbName.Text = "";
            txbCity.Text = "";
            txbNeighbourhood.Text = "";
            txbStreet.Text = "";
            mtxbPhone.Text = "";
            mtxbPhone2.Text = "";
            cbxState.Text = "";
            mtxbZipCode.Text = "";
            mtxbCpf.Text = "";
        }

        #region API CEP
        private void mtxbZipCode_Leave(object sender, EventArgs e)
        {
            if (mtxbZipCode.Text.Length == 8)
            {
                Address? address = new();
                address = address.cepSearch(mtxbZipCode.Text);
                if (address.cep != null)
                    dataFoundZipCode(address);
                else
                {
                    MessageBox.Show("CEP invalido e/ou não encontrado");
                    mtxbZipCode.Text = "";
                    mtxbZipCode.Focus();
                    cleanAdress();
                }

            }
        }
        private void cleanAdress()
        {
            txbCity.Text = "";
            txbNeighbourhood.Text = "";
            txbStreet.Text = "";
            cbxState.Text = "";
        }

        private void dataFoundZipCode(Address address)
        {
            txbStreet.Text = address.logradouro;
            txbNeighbourhood.Text = address.bairro;
            txbCity.Text = address.localidade;
            cbxState.Text = address.uf;
        }


        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;

                UserDAL dal = new UserDAL(new SqlConnection(connectionString));
                Client client = new();
                client = dal.SearchOne(mtxbCpf.Text);
                fillFields(client);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
                mtxbCpf.Focus();
                return;
            }

            unlockFields();


        }

        private void fillFields(Client client)
        {
            txbName.Text = client.name;
            txbCity.Text = client.address.localidade;
            txbNeighbourhood.Text = client.address.bairro;
            txbStreet.Text = client.address.logradouro;
            mtxbPhone.Text = client.phone;
            mtxbPhone2.Text = client.phone2;
            cbxState.Text = client.address.uf;
            mtxbZipCode.Text = client.address.cep;
        }

        private void mtxbCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if(mtxbCpf.MaskCompleted == true)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        private bool cepIsValid()
        {
            if(mtxbZipCode.MaskFull == false) throw new Exception("Digite o CEP completo");
            

            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;
                UserDAL dal = new(new SqlConnection(connectionString));

                Client client = new();
                client = getData();

                updateClient(dal, client);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void updateClient(UserDAL dal, Client client)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que quer alterar esses dados?", "Atualização de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (cepIsValid())
                {
                    dal.Update(client);
                    MessageBox.Show("Dados atualizados com sucesso", "Sucesso");
                    unlockFields();
                }
            }
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
            if (txbName.Text == "")
            {
                throw new Exception("Digite o nome: ");
            }
            client.setName(txbName.Text.ToUpper());
            client.setCpf(mtxbCpf.Text.ToUpper());
            client.setPhone(mtxbPhone.Text.ToUpper());
            client.setPhone2(mtxbPhone2.Text.ToUpper());
            client.setAddress(address);
            return client;
        }
        private Client getData()
        {
            try
            {
                Address address = new();
                address = getAddress(address);

                Client client = new();
                client = getClient(client, address);
                return client;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
