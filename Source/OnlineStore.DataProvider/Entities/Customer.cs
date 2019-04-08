using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public int ApplicationUserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<DeliveryInformation> DeliveryInformation { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
