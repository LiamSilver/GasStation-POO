using GasStation.Models;
using System.Data.SqlClient;

namespace GasStation.Persistence.DAL
{
    public class UserDAL
    {
        private SqlConnection _sqlConnection;

        public UserDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        public void Insert(Client client)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO tbCLIENTE (Nome, Cpf, Telefone, Telefone2, Cep, Bairro, Cidade, Uf, Rua)" +
                                  "VALUES (@Nome, @Cpf, @Telefone, @Telefone2, @Cep, @Bairro, @Cidade, @Uf, @Rua)";

            command.Parameters.AddWithValue("@Nome", client.name);
            command.Parameters.AddWithValue("Cpf", client.cpf);
            command.Parameters.AddWithValue("@Telefone", client.phone);
            command.Parameters.AddWithValue("@Telefone2", client.phone2);
            command.Parameters.AddWithValue("@Cep", client.address.cep);
            command.Parameters.AddWithValue("@Bairro", client.address.bairro);
            command.Parameters.AddWithValue("@Cidade", client.address.localidade);
            command.Parameters.AddWithValue("@Uf", client.address.uf);
            command.Parameters.AddWithValue("@Rua", client.address.logradouro);

            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Update(Client client)
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = "UPDATE tbCLIENTE " +
                                  "SET Nome = @Nome, " +
                                  "Telefone = @Telefone, " +
                                  "Telefone2 = @Telefone2, " +
                                  "Cep = @Cep, " +
                                  "Bairro = @Bairro, " +
                                  "Cidade = @Cidade, " +
                                  "Uf = @Uf, " +
                                  "Rua = @Rua " +
                                  "WHERE Cpf = @Cpf ";

            command.Parameters.AddWithValue("@Nome", client.name);
            command.Parameters.AddWithValue("Cpf", client.cpf);
            command.Parameters.AddWithValue("@Telefone", client.phone);
            command.Parameters.AddWithValue("@Telefone2", client.phone2);
            command.Parameters.AddWithValue("@Cep", client.address.cep);
            command.Parameters.AddWithValue("@Bairro", client.address.bairro);
            command.Parameters.AddWithValue("@Cidade", client.address.localidade);
            command.Parameters.AddWithValue("@Uf", client.address.uf);
            command.Parameters.AddWithValue("@Rua", client.address.logradouro);

            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Delete(string cpf)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = $"DELETE FROM tbCLIENTE WHERE Cpf = '{cpf}'";

            command.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public Client SearchOne(string cpf)
        {
            Client client = new();
            Address? address = new();

            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.Parameters.AddWithValue("@Cpf", cpf);
            int result = hasCpf(command);

            if (result != 1)
            {
                _sqlConnection.Close();
                throw new Exception("Cpf não encontrado na nossa base de dados");
            }

            command.CommandText = $"SELECT * FROM tbCLIENTE WHERE Cpf = '{cpf}'";

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            address = new(reader.GetString(5), reader.GetString(7), reader.GetString(6), reader.GetString(9), reader.GetString(8));
            client = new(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), address);
            reader.Close();


            _sqlConnection.Close();
            return client;
        }


        private static int hasCpf(SqlCommand command)
        {
            command.CommandText = "SELECT COUNT(Cpf) FROM tbCLIENTE WHERE Cpf = @Cpf";
            int result = (int)command.ExecuteScalar();
            return result;
        }

        public bool checkCpfExistence(string cpf)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.Parameters.AddWithValue("@Cpf", cpf);

            int result = hasCpf(command);
            _sqlConnection.Close();

            if (result != 0)
            {
                throw new Exception("CPF já cadastrado");
            }
            
            return false;
        }

        public void getPurchases(DataGridView dgv, string cpf = "00000000000")
        {
            _sqlConnection.Open();

            SqlCommand command = _sqlConnection.CreateCommand();

            command.CommandText = "SELECT DescBomba, DescricaoCombustivel, QtdLitro, ValorLitro, ValorLitro*QtdLitro, DataVenda, Situacao" +
                                  " FROM tbVENDA INNER JOIN tbBOMBA_COMBUSTIVEL ON (tbVENDA.CodBomba = tbBOMBA_COMBUSTIVEL.CodBomba)"+
                                  $" inner join tbCOMBUSTIVEL on (tbBOMBA_COMBUSTIVEL.TipoCombustivel=tbCOMBUSTIVEL.CodCombustivel) WHERE CpfCliente = '{cpf}'"+
                                  " Order by DataVenda DESC";

            SqlDataReader reader = command.ExecuteReader();

            string[] data = new string[reader.FieldCount];
            while (reader.Read())
            {
                data[0] = reader.GetString(0);
                data[1] = reader.GetString(1);
                data[2] = reader.GetDecimal(2).ToString("N2") +" L";
                data[3] = "R$: "+ reader.GetDecimal(3).ToString("N3");
                data[4] = "R$: " + reader.GetDecimal(4).ToString("N2");
                data[5] = reader.GetDateTime(5).Date.ToString();
                data[6] = reader.GetString(6);
                dgv.Rows.Add(data);
            }
            _sqlConnection.Close();
        }
    }
}
