using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string License { get; set; }
    }
}
