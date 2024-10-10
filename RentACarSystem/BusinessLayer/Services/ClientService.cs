using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;


namespace BusinessLayer.Services
{
    public class ClientService
    {
        private ClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public DataTable GetAllClients()
        {
            return _clientRepository.GetClients();
        }

        public void AddClient(Client client)
        {
            _clientRepository.AddClient(client);
        }

        public void EditClient(Client client)
        {
            _clientRepository.EditClient(client);
        }
        
        public void DeleteClient(int ClientId)
        {
            _clientRepository.DeleteClient(ClientId);
        }
    }
}
