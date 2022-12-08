using GasStation.Models;
using GasStation.Persistence.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation.View.User
{
    public partial class deleteUser : Form
    {
        public deleteUser()
        {
            InitializeComponent();
        }

        #region search
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

            unlockDeleteButton();
        }

        #endregion

        #region delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mtxbCpf.Text == "00000000000")
            {
                MessageBox.Show("Não é possivel deleter o usuario ADMIN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;

                UserDAL dal = new UserDAL(new SqlConnection(connectionString));

                SaleDAL saleDAL = new SaleDAL(new SqlConnection(connectionString));
                
                if(saleDAL.searchClientHasPurchases(mtxbCpf.Text) == false)
                deleteClient(dal);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
                mtxbCpf.Focus();
                return;
            }


        }

        private void deleteClient(UserDAL dal)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que quer apagar esse usuário? Não será possível recuperar os dados depois!", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dal.Delete(mtxbCpf.Text);
                    MessageBox.Show("Usuário deletado com sucesso!", "Sucesso");

                    unlockAndClean();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        #endregion 

        #region utils
        private void unlockDeleteButton()
        {
            if(btnSearch.Text == "Buscar")
            {
                btnDelete.Enabled = true;
                mtxbCpf.Enabled = false;
                btnSearch.Text = "Cancelar";
            }
            else
            {
                btnDelete.Enabled = false;
                mtxbCpf.Enabled = true;
                btnSearch.Text = "Buscar";
                mtxbCpf.Text = "";
                mtxbCpf.Focus();
                cleanFields();
            }
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

        private void cleanFields()
        {
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
        private void unlockAndClean()
        {
            cleanFields();
            unlockDeleteButton();
        }



        #endregion

        #region keypress
        private void mtxbCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (mtxbCpf.MaskCompleted == true)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }

        }

        #endregion
    }
}
