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
        #region utils
        private void unlockFields()
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

        private void cleanFields() {
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


        #endregion

        #region API CEP
        private void mtxbZipCode_Leave(object sender, EventArgs e)
        {
            if (mtxbZipCode.Text.Length == 8)
            {
                Address? address = new(mtxbZipCode.Text);
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

        #region keypress
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
        #endregion

        #region update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbName.Text != "ADMIN" && mtxbCpf.Text=="00000000000")
            {
                MessageBox.Show("Não é possivel alterar o nome do usuario ADMIN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                try
                {
                    dal.Update(client);
                    MessageBox.Show("Dados atualizados com sucesso", "Sucesso");
                    unlockFields();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        #endregion

        #region search
        private Client getData()
        {
            try
            {
                Address address = new(mtxbZipCode.Text, txbCity.Text, txbNeighbourhood.Text, txbStreet.Text, cbxState.Text);
                Client client = new();
                client = new(txbName.Text, mtxbCpf.Text, mtxbPhone.Text, mtxbPhone2.Text, address);
                return client;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        #endregion
    }
}
