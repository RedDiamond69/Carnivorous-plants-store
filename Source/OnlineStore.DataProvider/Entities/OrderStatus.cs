using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class OrderStatus
    {
        [Key]
        public string OrderStatusId { get; set; }

        [Required(ErrorMessage = "Image is required."), MaxLength(250, ErrorMessage = "Filename length cannot be more than 250.")]
        public string StatusImageFilename { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderStatusTranslate> OrderStatusTranslates { get; set; }

        public OrderStatus()
        {
            OrderStatusId = Guid.NewGuid().ToString();
            Orders = new List<Order>();
            OrderStatusTranslates = new List<OrderStatusTranslate>();
        }
    }
}
