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

            changeSearchButton();
        }

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

    }
}
