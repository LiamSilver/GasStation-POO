using GasStation.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Persistence.DAL
{
    public class FuelDAL
    {
        private SqlConnection _sqlConnection;
        public FuelDAL(SqlConnection connection) {
            _sqlConnection = connection;        
        }

        public void updatePrice(int codCombustivel, decimal price)
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = "UPDATE tbCOMBUSTIVEL SET ValorCombustivel = @Price WHERE CodCombustivel = @Cod";
            command.Parameters.AddWithValue("@Cod", codCombustivel);
            command.Parameters.AddWithValue("@Price", price);
            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public FuelPump searchPumpByFuelId(int fuelId)
        {
            FuelPump pump = new();
            Fuel fuel = new();
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM tbCOMBUSTIVEL INNER JOIN tbBOMBA_COMBUSTIVEL ON " +
                "(tbBOMBA_COMBUSTIVEL.TipoCombustivel = tbCOMBUSTIVEL.CodCombustivel) WHERE CodCombustivel = @Cod";
            command.Parameters.AddWithValue("@Cod", fuelId);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            fuel.setCod(reader.GetInt32(0));
            fuel.setFuelPrice(reader.GetDecimal(1));
            fuel.setDesc(reader.GetString(2));
            pump.setCapacity(reader.GetDecimal(4));
            pump.setTypeFuel(fuel);
            pump.setDescPump(reader.GetString(6));
            pump.setFuelAvailable(reader.GetDecimal(7));
            reader.Close();

            _sqlConnection.Close();

            return pump;
        }
    }
}
