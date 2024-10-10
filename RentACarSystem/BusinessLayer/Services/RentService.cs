using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class RentService
    {
        private RentRepository _rentRepository;

        public RentService()
        {
            _rentRepository = new RentRepository();
        }

        public DataTable GetCars()
        {
            return _rentRepository.GetCars();
        }

        public DataTable GetClients()
        {
            return _rentRepository.GetClients();
        }

        public DataTable GetRents()
        {
            return _rentRepository.GetRents();
        }

        public void AddRent(Rent rent)
        {
            _rentRepository.AddRent(rent);
        }
        public void EditRent(Rent rent)
        {
            _rentRepository.EditRent(rent);
        }

        public void DeleteRent(int rentId)
        {
            _rentRepository.DeleteRent(rentId);
        }
    }
}