using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Customer
    {
        public Guid ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<DeliveryInformation> DeliveryInformation { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
            DeliveryInformation = new List<DeliveryInformation>();
            Orders = new List<Order>();
        }
    }
}
