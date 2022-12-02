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

namespace GasStation.View.Sale
{
    public partial class saleGas : Form
    {
        public saleGas()
        {
            InitializeComponent();
            cbCpfAdmin.Focus();
            searchClient();
            loadFuel();
        }

        private void loadFuel()
        {
            PumpDAL dal = dbConnectionPump();
            int counter= dal.countPump();

            for(int cod=0; cod<counter; cod++)
            {
                FuelPump pump = dal.getPump(cod);
                cbFuel.Items.Add(pump.typeFuel.descFuel);
            }
            cbFuel.SelectedIndex = 0;
        }

        #region ConnectionDB
        private static UserDAL dbConnectionUser()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;
            UserDAL dal = new UserDAL(new SqlConnection(connectionString));
            return dal;
        }
        private static PumpDAL dbConnectionPump()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;
            PumpDAL dal = new PumpDAL(new SqlConnection(connectionString));
            return dal;
        }
        private static FuelDAL dbConnectionFuel()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GasStation"].ConnectionString;
            FuelDAL dal = new FuelDAL(new SqlConnection(connectionString));
            return dal;
        }
        #endregion
        private void cbCpfAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbCpfAdmin.Checked)
            {
                mtxbCpf.Enabled = true;
                resetClientFlelds();
            }

            else 
            {
                mtxbCpf.Enabled = false;
                searchClient();
                mtxbCpf.Text = "";
                btnSearchClient.Enabled = false;
             }

            mtxbCpf.Focus();
        }

        private void mtxbCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (mtxbCpf.MaskCompleted) btnSearchClient.Enabled = true;
            else
            {
                btnSearchClient.Enabled = false;
                resetClientFlelds();
            }

        }

        private void resetClientFlelds()
        {
            lblName.Text = "";
            lblPhone.Text = "";
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                searchClient(mtxbCpf.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}", "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchClient(string cpf = "00000000000")
        {
            UserDAL user = dbConnectionUser();
            Client client = new();
            client = user.SearchOne(cpf);
            fillNameAndPhone(client);
        }

        private void fillNameAndPhone(Client client)
        {
            lblName.Text = client.name;
            lblPhone.Text = client.phone;
            if (client.phone is null || client.phone.Length == 0)
            {
                lblPhone.Text = client.phone2;
            }
            if (client.phone2 is null || client.phone2.Length == 0)
            {
                lblPhone.Text = "Sem telefone";
            }

        }

        private void cbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPump();

        }

        private void loadPump()
        {
            int cod = cbFuel.SelectedIndex;
            FuelDAL fuel = dbConnectionFuel();
            FuelPump pump = new();

            pump = fuel.searchPumpByFuelId(++cod);

            fillPumpFields(pump);
        }

        private void fillPumpFields(FuelPump pump)
        {
            lblFuelPrice.Text = "R$ " + Convert.ToString(pump.typeFuel.fuelPrice) + " Litro";
            lblLabelFuelAvailable.Text = "Combustível disponível: " + pump.fuelAvailable + " Litros";
            lblPump.Text = pump.descPump;
        }

        private void saleGas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar!= null)
            {
                e.Handled= true;
            }
        }
    }
}
