using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class OrderItem
    {
        public Guid ProductParameterID { get; set; }
        public virtual ProductParameter ProductParameter { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price { get; set; }

        public Guid OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
