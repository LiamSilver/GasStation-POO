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

namespace GasStation.View.Pump
{
    public partial class pumpControl : Form
    {
        int CodPump = 0;
        public pumpControl()
        {
            InitializeComponent();


            loadPump();
            loadHistoric();
        }


        #region load
        private void loadPump()
        {
            try
            {
                PumpDAL dal = dbConnection();

                FuelPump pump = new();

                pump = dal.getPump(CodPump);
                fillFields(pump);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
        }
        private void loadHistoric()
        {
            try
            {
               FuelPump pump = getDataPump(CodPump);
               FuelDAL dal = dbConnectionFuel();

                dal.searchHistoric(pump.typeFuel.CodCombustivel, dgvHistoric);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
        }



        private FuelPump getDataPump(int cod)
        {
            PumpDAL dal = dbConnection();
            FuelPump pump = new();
            pump = dal.getPump(cod);
            return pump;
        }

        #endregion
        #region price
        private void verifyNewPrice()
        {
            if (txbFuelPrice.TextLength != 0)
            {
                double notZero = Convert.ToDouble(txbFuelPrice.Text);
                if (!notZero.Equals(0))
                {
                    defineNewPrice();
                }
                else
                {
                    MessageBox.Show("O novo valor do combustível não pode ser 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbFuelPrice.Focus();

                }
            }
            else
            {
                MessageBox.Show("O novo valor do combustível não pode estar vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbFuelPrice.Focus();
            }
        }

        private void defineNewPrice()
        {
            if (btnCancel.Visible == false)
            {
                btnCancel.Visible = true;
                txbFuelPrice.Enabled = true;
                txbFuelPrice.Focus();
                txbFuelPrice.Text = "";
                disableButtons();
            }

            else
            {
                updateFuelPrice();
                resetFields();
                enableButtons();
            }
        }

        private void updateFuelPrice()
        {

            FuelPump pump = getDataPump(CodPump);
            FuelDAL dal = dbConnectionFuel();

            string value = txbFuelPrice.Text.Replace(".", ",");
            dal.updatePrice(pump.typeFuel.CodCombustivel, Convert.ToDecimal(value));
            dgvHistoric.Rows.Clear();
            loadHistoric();

        }

        #endregion

        #region utils

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadPump();
            resetFields();
            enableButtons();
        }

        private void resetFields()
        {
            btnCancel.Visible = false;
            txbFuelPrice.Enabled = false;
            getDataPump(CodPump);
        }

        private void disableButtons()
        {
            btnFillPump.Enabled = false;
            btnNextPump.Enabled = false;
            btnPreviousPump.Enabled = false;
        }

        private void enableButtons()
        {
            btnFillPump.Enabled = true;
            btnNextPump.Enabled = true;
            btnPreviousPump.Enabled = true;
        }
        private void fillFields(FuelPump pump)
        {
            lblFuelName.Text = pump.typeFuel.nameFuel;
            txbFuelPrice.Text = Convert.ToString(pump.typeFuel.FuelPrice);

            lblPumpName.Text = pump.namePump;
            lblCapacity.Text = Convert.ToString(pump.pumpCapacity) + " Litros";
            lblFuel.Text = Convert.ToString(pump.fuelAvailable) + " Litros";
        }


        #endregion

        #region keypress
        private void txbFuelPrice_TextChanged(object sender, EventArgs e)
        {
         }

        
        private void txbFuelPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita apenas números");
            }

            if (txbFuelPrice.Text.Contains(",") && e.KeyChar==',')
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita apenas uma virgula");

            }

            if (txbFuelPrice.TextLength==0 && e.KeyChar==',')
            {
                e.Handled = true;
                MessageBox.Show("Digite um número antes da virgula");

            }

            if(txbFuelPrice.TextLength == 2 && !txbFuelPrice.Text.Contains(','))
            {
                if(!char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar != ',')
                    {
                        e.Handled = true;
                        MessageBox.Show("Esse campo não aceita um número maior que 99,999");
                        txbFuelPrice.Focus();
                    }
                }
            }
        }

        #endregion

        #region buttons click
        private void btnFillPump_Click(object sender, EventArgs e)
        {
            if(string.Equals(lblCapacity.Text,lblFuel.Text))
            {
                MessageBox.Show("A bomba já esta cheia", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    PumpDAL dal = dbConnection();
                    dal.supplyPump(1+CodPump);
                    MessageBox.Show("Bomba abastecida com sucesso", "Sucesso", MessageBoxButtons.OK);
                    loadPump();

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"{ex.Message}");
                }
            }
            
        }
        private void btnNextPump_Click(object sender, EventArgs e)
        {

            try
            {
                FuelPump pump = getDataPump(++CodPump);
                fillFields(pump);
                btnPreviousPump.Enabled = true;
                dgvHistoric.Rows.Clear();
                loadHistoric();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Aviso", MessageBoxButtons.OK);
                CodPump--;
                btnNextPump.Enabled = false;
            }
        }

        private void btnPreviousPump_Click(object sender, EventArgs e)
        {
            try
            {
                FuelPump pump = getDataPump(--CodPump);
                fillFields(pump);
                btnNextPump.Enabled = true;
                dgvHistoric.Rows.Clear();
                loadHistoric();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Aviso", MessageBoxButtons.OK);
                CodPump++;
                btnPreviousPump.Enabled = false;
            }
        }
        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            verifyNewPrice();
        }

        #endregion

        #region dbConnection
        private static PumpDAL dbConnection()
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

    }
}

