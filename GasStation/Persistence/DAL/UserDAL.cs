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
            Address address = new();

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

            userReader(client, address, command);

            _sqlConnection.Close();
            return client;
        }


        private static void userReader(Client client, Address address, SqlCommand command)
        {
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            setReaderInClient(client, address, reader);

            reader.Close();
        }

        private static void setReaderInClient(Client client, Address address, SqlDataReader reader)
        {
            client.setName(reader.GetString(1));
            client.setCpf(reader.GetString(2));
            client.setPhone(reader.GetString(3));
            client.setPhone2(reader.GetString(4));
            address.setCep(reader.GetString(5));
            address.setNeighbourhood(reader.GetString(6));
            address.setCity(reader.GetString(7));
            address.setState(reader.GetString(8));
            address.setStreet(reader.GetString(9));
            client.setAddress(address);
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
    }
}
