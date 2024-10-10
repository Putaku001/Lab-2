using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer.Repositories;
using CommonLayer.Entities;


namespace BusinessLayer.Services
{
    public class CarService
    {
        private CarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }

        public DataTable GetAllCars()
        {
            return _carRepository.GetCars();
        }
        
        public void AddCar(Car car)
        {
            _carRepository.addCars(car);
        }

        public void EditCar(Car car)
        {
            _carRepository.EditCar(car);
        }

        public void DeleteCar(int carId)
        {
            _carRepository.DeleteCar(carId);
        }
        
    }
}
