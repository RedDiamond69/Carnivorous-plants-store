using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }

        public virtual Payment Payment { get; set; }

        [Required, ForeignKey("CustomerID")]
        public Guid CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [Required, ForeignKey("ManagerID")]
        public Guid ManagerID { get; set; }
        public virtual Manager Manager { get; set; }

        [Required, ForeignKey("OrderStatusID")]
        public Guid OrderStatusID { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }

        [Required, ForeignKey("DeliveryTypeID")]
        public Guid DeliveryTypeID { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime DateTime { get; set; }

        [Required, ForeignKey("DeliveryInformationID")]
        public Guid DeliveryInformationID { get; set; }
        public virtual DeliveryInformation DeliveryInformation { get; set; }

        [MaxLength(1000, ErrorMessage = "Comment length cannot be more than 1000.")]
        public string Comment { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
