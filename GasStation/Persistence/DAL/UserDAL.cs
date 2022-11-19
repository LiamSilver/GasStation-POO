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

        public void Inserir(Client client)
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
    }
}
