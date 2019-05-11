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
        public string ProductParameterId { get; set; }

        [Required, ForeignKey("Dimension")]
        public string DimensionId { get; set; }
        public virtual Dimension Dimension { get; set; }

        [Required, ForeignKey("Product")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public bool Availability { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ProductParameterTranslate> ProductParameterTranslates { get; set; }

        public ProductParameter()
        {
            ProductParameterId = Guid.NewGuid().ToString();
            DimensionId = Guid.NewGuid().ToString();
            ProductId = Guid.NewGuid().ToString();
            OrderItems = new List<OrderItem>();
            ProductParameterTranslates = new List<ProductParameterTranslate>();
        }
    }
}
