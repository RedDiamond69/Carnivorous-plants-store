using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductParameter
    {
        public int ProductParameterID { get; set; }

        public int DimensionID { get; set; }
        public Dimension Dimension { get; set; }

        public decimal Price { get; set; }

        public bool Availability { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int StorageItemID { get; set; }
        public Storage Storage { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
