using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductParameter
    {
        public Guid ProductParameterID { get; set; }

        public Guid DimensionID { get; set; }
        public virtual Dimension Dimension { get; set; }

        public decimal Price { get; set; }

        public bool Availability { get; set; }

        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }

        public Guid StorageItemID { get; set; }
        public virtual Storage Storage { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
