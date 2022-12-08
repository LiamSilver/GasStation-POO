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
    public partial class consultUser : Form
    {
        public consultUser()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;

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

        #region search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                UserDAL dal = new UserDAL(new SqlConnection(connectionString));
                Client client = new();

                client = dal.SearchOne(mtxbCpf.Text);
                fillFields(client);

                fillDgv();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
                mtxbCpf.Focus();
                return;
            }

            changeSearchButton();
        }

        private void searchPurchasesClientByFuel()
        {
            SaleDAL dal = new SaleDAL(new SqlConnection(connectionString));

            int pump = Convert.ToInt32(dgvUser.CurrentRow.Cells[8].Value);
            dgvUser.Rows.Clear();
            fillDgvByFuel(pump);

        }

        #endregion

        #region utils
        private void changeSearchButton()
        {
            if (btnSearch.Text == "Buscar")
            {
                mtxbCpf.Enabled = false;
                btnSearch.Text = "Cancelar";
            }
            else
            {
                mtxbCpf.Enabled = true;
                btnSearch.Text = "Buscar";
                mtxbCpf.Text = "";
                mtxbCpf.Focus();
                cleanFields();
                dgvUser.Rows.Clear();
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
        private void fillDgv()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;

            UserDAL dal = new UserDAL(new SqlConnection(connectionString));
            dal.getPurchases(dgvUser, mtxbCpf.Text);
        }

        private void fillDgvByFuel(int pump)
        {
            UserDAL dal = new UserDAL(new SqlConnection(connectionString));
            dal.getPurchasesbyFuel(dgvUser, pump, mtxbCpf.Text);
        }

        #endregion

        #region delete 

        private void deleteSell()
        {
            SaleDAL dal = new SaleDAL(new SqlConnection(connectionString));

            int cod = Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value);
            dal.deleteSell(cod);
            dgvUser.Rows.Clear();
            fillDgv();
        }

        #endregion

        #region dgv Click

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUser.CurrentCell.ColumnIndex == 7)
            {
                dgvUser.CurrentRow.Selected = true;
                DialogResult result = MessageBox.Show("Você tem certeza que quer cancelar essa venda? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        deleteSell();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"{ex.Message}");
                    }
                }

            }

            if (dgvUser.CurrentCell.ColumnIndex == 2)
            {
                DialogResult result = MessageBox.Show("Voce quer filtrar pelos tipos de combustivel que esse cliente comprou?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        searchPurchasesClientByFuel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                }
            }
        }

        #endregion
    }
}
