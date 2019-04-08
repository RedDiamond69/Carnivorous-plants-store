using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Storage
    {
        public int StorageItemID { get; set; }

        public int Quantity { get; set; }

        public ICollection<ProductParameter> ProductParameters { get; set; }
    }
}
