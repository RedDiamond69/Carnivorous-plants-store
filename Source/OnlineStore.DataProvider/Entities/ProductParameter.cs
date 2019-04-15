using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductParameter
    {
        [Key]
        public Guid ProductParameterID { get; set; }

        [Required, ForeignKey("DimensionID")]
        public Guid DimensionID { get; set; }
        public virtual Dimension Dimension { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool Availability { get; set; }

        [Required, ForeignKey("ProductID")]
        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }

        [Required, ForeignKey("StorageItemID")]
        public Guid StorageItemID { get; set; }
        public virtual Storage Storage { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public ProductParameter()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
