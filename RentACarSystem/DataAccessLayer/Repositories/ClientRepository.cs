using DataAccessLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class ClientRepository
    {
        private SqlConnect _dbConnect;

        public ClientRepository()
        {
            _dbConnect = new SqlConnect();
        }

        public DataTable GetClients()
        {
            DataTable clientsTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT ClienteID, Nombre, Apellido, Telefono, Licencia FROM Clientes";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                clientsTable.Load(reader);
            }
            return clientsTable;
        }

        public void AddClient(Client client)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "INSERT INTO Clientes (Nombre, Apellido, Telefono, Licencia) VALUES (@Nombre, @Apellido, @Telefono, @Licencia)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", client.Name);
                command.Parameters.AddWithValue("@Apellido", client.LastName);
                command.Parameters.AddWithValue("@Telefono", client.Telephone);
                command.Parameters.AddWithValue("@Licencia", client.License);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditClient(Client client)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Licencia = @Licencia WHERE ClienteID = @ClienteID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteID", client.ClientID);
                command.Parameters.AddWithValue("@Nombre", client.Name);
                command.Parameters.AddWithValue("@Apellido", client.LastName);
                command.Parameters.AddWithValue("@Telefono", client.Telephone);
                command.Parameters.AddWithValue("@Licencia", client.License);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteClient(int clientId)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteID", clientId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
