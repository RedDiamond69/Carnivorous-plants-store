using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class OrderStatus
    {
        public Guid OrderStatusID { get; set; }

        public string StatusName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public OrderStatus()
        {
            Orders = new List<Order>();
        }
    }
}
