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
        [Required, ForeignKey("ProductParameterID")]
        public Guid ProductParameterID { get; set; }
        public virtual ProductParameter ProductParameter { get; set; }

        [Required]
        public int ItemQuantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, ForeignKey("OrderID")]
        public Guid OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
