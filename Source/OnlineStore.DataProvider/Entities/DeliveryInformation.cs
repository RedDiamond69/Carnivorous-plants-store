using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class DeliveryInformation
    {
        public int DeliveryInformationID { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public string Sity { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string Apartment { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
