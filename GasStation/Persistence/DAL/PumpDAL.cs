using GasStation.Models;
using Persistence.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GasStation.Persistence.DAL
{
    public class PumpDAL
    {
        private SqlConnection _sqlConnection;

        public PumpDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public FuelPump getPump(int cod)
        {
            FuelPump pump = new();
            Fuel fuel = new();
            _sqlConnection.Open();

            string SQL = "SELECT capacidadeMaxima,DescBomba,QtdCombustivelAtual,ValorCombustivel,DescricaoCombustivel,CodCombustivel " +
            "FROM tbBOMBA_COMBUSTIVEL INNER JOIN tbCOMBUSTIVEL ON (tbBOMBA_COMBUSTIVEL.TipoCombustivel = tbCOMBUSTIVEL.CodCombustivel)";
            string SQLOrderBy = "ORDER BY CodBomba";
            String limitedSQL = SQLUtils.GetPaginatedSQL(cod, 1, SQL, SQLOrderBy);

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = limitedSQL; 
            //"SELECT capacidadeMaxima,DescBomba,QtdCombustivelAtual,ValorCombustivel,DescricaoCombustivel,CodCombustivel " +
            // "FROM tbBOMBA_COMBUSTIVEL INNER JOIN tbCOMBUSTIVEL ON (tbBOMBA_COMBUSTIVEL.TipoCombustivel = tbCOMBUSTIVEL.CodCombustivel) WHERE CodBomba = @CodBomba";

            //command.Parameters.AddWithValue("@CodBomba", cod);

            SqlDataReader reader = command.ExecuteReader();

            read(pump, fuel, reader);
            _sqlConnection.Close();

            return pump;

        }

        public int countPump()
        {
            int count;

            
            _sqlConnection.Open();

            string SQL = "SELECT COUNT(CodBomba)" +
            "FROM tbBOMBA_COMBUSTIVEL";

            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText= SQL;

            count = (int) command.ExecuteScalar();

            _sqlConnection.Close();

            return count;
        }

        private static void read(FuelPump pump, Fuel fuel, SqlDataReader reader)
        {
            reader.Read();
            setReaderInPump(pump, fuel, reader);
            reader.Close();
        }

        private static void setReaderInPump(FuelPump pump, Fuel fuel, SqlDataReader reader)
        {
            try
            {
                pump.setCapacity(reader.GetDecimal(1));
                pump.setDescPump(reader.GetString(2));
                pump.setFuelAvailable(reader.GetDecimal(3));
                fuel.setDesc(reader.GetString(5));
                fuel.setFuelPrice(reader.GetDecimal(4));
                fuel.setCod(reader.GetInt32(6));
                pump.setTypeFuel(fuel);

            }
            catch (Exception ex)
            {

                throw new Exception("Não tem outra bomba no momento");
            }
        }

        public void supplyPump(int cod)
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = $"UPDATE tbBOMBA_COMBUSTIVEL SET QtdCombustivelAtual = CapacidadeMaxima WHERE CodBomba = {cod}";

            command.ExecuteNonQuery();
            _sqlConnection.Close();

        }
    }
}

namespace Persistence.Utils
{
    public class SQLUtils
    {
        /// <summary>
        /// Builds a paginated/limited query from a SELECT SQL.
        /// </summary>
        /// <param name="startRow">Start row</param>
        /// <param name="numberOfRows">Number/quatity of rows to be expected</param>
        /// <param name="sql">Original SQL (without its ordering clause)</param>
        /// <param name="orderingClause">MANDATORY: ordering clause (including ORDER BY keywords)</param>
        /// <returns>Paginated SQL ready to be executed.</returns>
        /// <remarks>SELECT keyword of original SQL must be placed exactly at the beginning of the SQL.</remarks>
        public static string GetPaginatedSQL(int startRow, int numberOfRows, string sql, string orderingClause)
        {
            // Ordering clause is mandatory!
            if (String.IsNullOrEmpty(orderingClause))
                throw new ArgumentNullException("orderingClause");

            // numberOfRows here is checked of disable building paginated/limited query
            // in case is not greater than 0. In this case we simply return the
            // query with its ordering clause appended to it. 
            // If ordering is not spe
            if (numberOfRows <= 0)
            {
                return String.Format("{0} {1}", sql, orderingClause);
            }
            // Extract the SELECT from the beginning.
            String partialSQL = sql.Remove(0, "SELECT ".Length);

            // Build the limited query...
            return String.Format(
                "SELECT * FROM ( SELECT ROW_NUMBER() OVER ({0}) AS rn, {1} ) AS SUB WHERE rn > {2} AND rn <= {3}",
                orderingClause,
                partialSQL,
                startRow.ToString(),
                (startRow + numberOfRows).ToString()
            );
        }
    }
}