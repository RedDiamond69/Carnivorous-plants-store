using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Order
    {
        public Guid OrderID { get; set; }

        public virtual Payment Payment { get; set; }

        public Guid CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public Guid ManagerID { get; set; }
        public virtual Manager Manager { get; set; }

        public Guid OrderStatusID { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }

        public Guid DeliveryTypeID { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }

        public DateTime DateTime { get; set; }

        public Guid DeliveryInformationID { get; set; }
        public virtual DeliveryInformation DeliveryInformation { get; set; }

        public string Comment { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
