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
            updatePriceByLiter();
            updatePricebyMoney();
        }

        private void loadPump()
        {
            FuelPump pump = searchPump();

            fillPumpFields(pump);
        }

        private FuelPump searchPump()
        {
            int cod = cbFuel.SelectedIndex;
            FuelDAL fuel = dbConnectionFuel();
            FuelPump pump = new();

            pump = fuel.searchPumpByFuelId(++cod);
            return pump;
        }

        private void fillPumpFields(FuelPump pump)
        {
            lblFuelPrice.Text = "R$ " + Convert.ToString(pump.typeFuel.fuelPrice) + " Litro";
            lblLabelFuelAvailable.Text = "Combustível disponível: " + pump.fuelAvailable + " Litros";
            lblPump.Text = pump.descPump;
        }

        #region keypress
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

        private void txbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if (txbMoney.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita apenas uma virgula");

            }

            if (txbMoney.TextLength == 0 && e.KeyChar == ',')
            {
                e.Handled = true;
                MessageBox.Show("Digite um número antes da virgula");

            }

            if (txbMoney.TextLength == 3 && e.KeyChar != ',' && !txbMoney.Text.Contains(",") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("O valor máximo permitido é de 999,99");

            }

        }

        private void nudLiter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nudLiter.Value > nudLiter.Maximum)
            {
                e.Handled = true;
            }
        }

        private void nudLiter_ValueChanged(object sender, EventArgs e)
        {
            if (nudLiter.Value > nudLiter.Maximum)
                nudLiter.Value = nudLiter.Minimum;

            updatePriceByLiter();
        }

        #endregion

        #region updatePrices
        private void updatePricebyMoney()
        {
            if (txbMoney.Text != "")
            {
                FuelPump pump = searchPump();
                decimal price;

                price = Convert.ToDecimal(txbMoney.Text) / pump.typeFuel.fuelPrice;
                lblQtdLiter.Text = price.ToString("N2") + " Litros";

            }
        }

        private void updatePriceByLiter()
        {
            FuelPump pump = searchPump();

            decimal price;

            price = nudLiter.Value * pump.typeFuel.fuelPrice;
            lblMoneyByLiters.Text = price.ToString("N2") + " Reais";
        }

        private void txbMoney_TextChanged(object sender, EventArgs e)
        {
            updatePricebyMoney();
        }

        #endregion
    }
}
