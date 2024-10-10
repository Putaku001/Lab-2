using CommonLayer.Entities;
using DataAccessLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RentRepository
    {
        private SqlConnect _dbConnect;

        public RentRepository()
        {
            _dbConnect = new SqlConnect();
        }

        public DataTable GetRents()
        {
            DataTable rentsTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = @"SELECT 
                                R.RentaID,
                                CONCAT(C.Nombre, ' ', C.Apellido) AS Cliente,
	                            C.Licencia,
                                CONCAT(V.Marca, ' ', V.Modelo) AS Carro,
                                FORMAT(R.FechaRenta, 'dd-MM-yyyy') AS FechaRenta,            -- Alias para FechaRenta
                                R.HoraRenta AS HoraRenta,
                                FORMAT(R.FechaDevolucion, 'dd-MM-yyyy') AS FechaDevolucion,  -- Alias para FechaDevolucion
                                R.HoraDevolucion AS HoraDevolucion
                                FROM 
                                  Rentas AS R
                                INNER JOIN 
                                  Clientes AS C ON R.ClienteID = C.ClienteID
                                  INNER JOIN 
                                  Vehiculos AS V ON R.VehiculoID = V.VehiculoID;";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                rentsTable.Load(reader);
            }
            return rentsTable;
        }

        public void AddRent(Rent rent)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = @"INSERT INTO Rentas (ClienteID, VehiculoID, FechaRenta,HoraRenta,FechaDevolucion,HoraDevolucion) 
                                VALUES (@ClienteID, @VehiculoID, @FechaRenta,@HoraRenta, @FechaDevolucion,@HoraDevolucion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClienteID", rent.ClientID);
                command.Parameters.AddWithValue("@VehiculoID", rent.CarID);
                command.Parameters.AddWithValue("@FechaRenta", rent.RentDate);
                command.Parameters.AddWithValue("@HoraRenta",rent.RentTime);
                command.Parameters.AddWithValue("@FechaDevolucion", rent.ReturnDate);
                command.Parameters.AddWithValue("@HoraDevolucion",rent.ReturnTime);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void EditRent(Rent rent)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = @"UPDATE Rentas SET ClienteID = @ClienteID, VehiculoID = @VehiculoID, FechaRenta = @FechaRenta,
                         HoraRenta=@HoraRenta, FechaDevolucion = @FechaDevolucion, HoraDevolucion=@HoraDevolucion WHERE RentaID = @RentaID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@RentaID", rent.RentID);
                command.Parameters.AddWithValue("@ClienteID", rent.ClientID);
                command.Parameters.AddWithValue("@VehiculoID", rent.CarID);
                command.Parameters.AddWithValue("@FechaRenta", rent.RentDate);
                command.Parameters.AddWithValue("@HoraRenta", rent.RentTime);
                command.Parameters.AddWithValue("@FechaDevolucion", rent.ReturnDate);
                command.Parameters.AddWithValue("@HoraDevolucion", rent.ReturnTime);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteRent(int rentId)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "DELETE FROM Rentas WHERE RentaID = @RentaID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RentaID", rentId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public DataTable GetCars()
        {
            DataTable CarsTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = @"SELECT VehiculoID, CONCAT(Marca, ' ', Modelo) AS CarFullName FROM Vehiculos
                                WHERE Disponibilidad=1";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                CarsTable.Load(reader);
            }
            return CarsTable;
        }

        public DataTable GetClients()
        {
            DataTable ClientTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = @"SELECT ClienteID, CONCAT(Nombre,' ', Apellido) AS ClientName FROM Clientes";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                ClientTable.Load(reader);
            }
            return ClientTable;
        }
    }
}
