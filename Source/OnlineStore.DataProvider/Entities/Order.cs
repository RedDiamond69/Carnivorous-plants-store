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
        public string OrderId { get; set; }

        public virtual Payment Payment { get; set; }

        [Required, ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required, ForeignKey("Manager")]
        public string ManagerId { get; set; }
        public virtual Manager Manager { get; set; }

        [Required, ForeignKey("OrderStatus")]
        public string OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }

        [Required, ForeignKey("DeliveryType")]
        public string DeliveryTypeId { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime DateTime { get; set; }

        [ForeignKey("DeliveryInformation")]
        public string DeliveryInformationId { get; set; }
        public virtual DeliveryInformation DeliveryInformation { get; set; }

        [MaxLength(1000, ErrorMessage = "Comment length cannot be more than 1000.")]
        public string Comment { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderId = Guid.NewGuid().ToString();
            CustomerId = Guid.NewGuid().ToString();
            DeliveryInformationId = Guid.NewGuid().ToString();
            DeliveryTypeId = Guid.NewGuid().ToString();
            ManagerId = Guid.NewGuid().ToString();
            OrderStatusId = Guid.NewGuid().ToString();
            OrderItems = new List<OrderItem>();
        }
    }
}
