using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Rent
    {
        public int RentID { get; set; }
        public int ClientID { get; set; }
        public int CarID { get; set; }
        public DateTime RentDate { get; set; }

        public string RentTime { get; set; }
        public DateTime? ReturnDate{ get; set; }

        public string ReturnTime{ get; set; }
    }
}
