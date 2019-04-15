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
        public Guid OrderStatusID { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(30, ErrorMessage = "Name length cannot be more than 30.")]
        public string StatusName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public OrderStatus()
        {
            Orders = new List<Order>();
        }
    }
}
