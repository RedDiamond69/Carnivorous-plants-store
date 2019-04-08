using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class OrderItem
    {
        public int ProductParameterID { get; set; }
        public ProductParameter ProductParameter { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
