using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Order
    {
        public int OrderID { get; set; }

        public int PaymentID { get; set; }
        public virtual Payment Payment { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int ManagerID { get; set; }
        public Manager Manager { get; set; }

        public int OrderStatusID { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public int DeliveryTypeID { get; set; }
        public DeliveryType DeliveryType { get; set; }

        public DateTime DateTime { get; set; }

        public int DeliveryInformationID { get; set; }
        public DeliveryInformation DeliveryInformation { get; set; }

        public string Comment { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
