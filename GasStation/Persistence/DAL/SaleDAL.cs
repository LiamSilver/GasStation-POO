using GasStation.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Persistence.DAL
{
    public class SaleDAL
    {
        private SqlConnection _sqlConnection;

        public SaleDAL(SqlConnection connection) {
            _sqlConnection = connection;
        }

        public void insert(Sell sell)
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            if (!hasFuelAvailable(sell))
            {
                _sqlConnection.Close();
                return;
            }
            command.CommandText = "INSERT INTO tbVENDA (CpfCliente, CodBomba, ValorLitro, QtdLitro)" +
                                 " VALUES (@Client, @Pump, @Price, @Liter)";

            command.Parameters.AddWithValue("@Client", sell.client.cpf);
            command.Parameters.AddWithValue("@Pump",sell.pump.codPump);
            command.Parameters.AddWithValue("@Price", sell.pump.typeFuel.FuelPrice);
            command.Parameters.AddWithValue("@Liter", sell.liter);

            command.ExecuteNonQuery();

            updatePumpGasAvailable(sell);

            _sqlConnection.Close();
        }
        
        public bool searchClientHasPurchases(string cpf)
        {

            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = $"SELECT COUNT(CpfCliente) FROM tbVENDA WHERE CpfCliente = {cpf}";
            int result = (int )command.ExecuteScalar();

            if (result != 0)
            throw new Exception("Não podemos apagar um cliente com compras");


            _sqlConnection.Close();
            return false;
        }

        public void deleteSell(int codCompra)
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = "UPDATE tbVENDA SET Situacao = 'CANCELADA' WHERE CodClienteVenda = @Cod";
            command.Parameters.AddWithValue("@Cod",codCompra);

            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void updatePumpGasAvailable(Sell sell)
        {
            SqlCommand update = _sqlConnection.CreateCommand();

            update.CommandText = "UPDATE tbBOMBA_COMBUSTIVEL SET QtdCombustivelAtual = QtdCombustivelAtual - @Liter WHERE CodBomba = @CodPump";
            update.Parameters.AddWithValue("@Liter", sell.liter);
            update.Parameters.AddWithValue("@CodPump", sell.pump.codPump);

            update.ExecuteNonQuery();
        }

        private bool hasFuelAvailable(Sell sell)
        {
            if (sell.pump.fuelAvailable - sell.liter < 0)
            {
                throw new Exception($"A bomba tem {sell.pump.fuelAvailable} litros de combustível disponíveis\n"
                                   + $"e você está tentando abastecer {sell.liter} Litros");
            }

            else return true;
        }


    }
}
