
using DataAccessLayer.dbConnect;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class CarRepository
    {
        private SqlConnect _dbConnect;

        public CarRepository()
        {
            _dbConnect = new SqlConnect();
        }

        public DataTable GetCars()
        {
            DataTable CarsTable = new DataTable();

            using (var connection = _dbConnect.GetConnection())
            {
                string query = "SELECT VehiculoID, Marca, Modelo, Año, Disponibilidad FROM Vehiculos";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                CarsTable.Load(reader);
            }
            return CarsTable;
        }
        public void addCars(Car car)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "INSERT INTO Vehiculos (Marca, Modelo, Año, Disponibilidad) VALUES (@Marca, @Modelo, @Año, @Disponibilidad)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Marca", car.Brand);
                command.Parameters.AddWithValue("@Modelo", car.Model);
                command.Parameters.AddWithValue("@Año", car.Year);
                command.Parameters.AddWithValue("@Disponibilidad", car.Availability);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void EditCar(Car car)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "UPDATE Vehiculos SET Marca = @Marca, Modelo = @Modelo, Año = @Año, Disponibilidad = @Disponibilidad WHERE VehiculoID = @VehiculoID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@VehiculoID",car.CarId);
                command.Parameters.AddWithValue("@Marca", car.Brand);
                command.Parameters.AddWithValue("@Modelo", car.Model);
                command.Parameters.AddWithValue("@Año", car.Year);
                command.Parameters.AddWithValue("@Disponibilidad", car.Availability);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
        public void DeleteCar(int CarId)
        {
            using (var connection = _dbConnect.GetConnection())
            {
                string query = "DELETE FROM Vehiculos WHERE VehiculoID = @VehiculoID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@VehiculoID", CarId);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
