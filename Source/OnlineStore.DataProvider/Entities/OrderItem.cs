using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class OrderItem
    {
        [Key]
        public string OrderItemId { get; set; }

        [Required, ForeignKey("ProductParameter")]
        public string ProductParameterId { get; set; }
        public virtual ProductParameter ProductParameter { get; set; }

        [Required]
        public int ItemQuantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, ForeignKey("Order")]
        public string OrderId { get; set; }
        public virtual Order Order { get; set; }

        public OrderItem()
        {
            OrderItemId = Guid.NewGuid().ToString();
            ProductParameterId = Guid.NewGuid().ToString();
            OrderId = Guid.NewGuid().ToString();
        }
    }
}
