﻿using GasStation.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            pump.setCodPump(reader.GetInt32(3));
            pump.setCapacity(reader.GetDecimal(4));
            pump.setTypeFuel(fuel);
            pump.setDescPump(reader.GetString(6));
            pump.setFuelAvailable(reader.GetDecimal(7));
            reader.Close();

            _sqlConnection.Close();

            return pump;
        }

        public void searchHistoric(int codFuel, DataGridView dgv)
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = $"SELECT descCombustivel,precoAntigo,novoPreco, dataAlteracao FROM tbHISTORICO_PRECO_COMBUSTIVEL WHERE tipoCombustivel = {codFuel}";

            SqlDataReader reader = command.ExecuteReader();

            int ncolumns = reader.FieldCount;

            string[] data = new string[ncolumns];

            while(reader.Read())
            {
                data[0] = reader.GetString(0);
                data[1] = reader.GetDecimal(1).ToString();
                data[2] = reader.GetDecimal(2).ToString();
                data[3] = reader.GetDateTime(3).ToString();

                dgv.Rows.Add(data);
            }
            _sqlConnection.Close();

        }
    }
}
