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
    }
}
