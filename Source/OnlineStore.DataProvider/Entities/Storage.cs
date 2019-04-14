using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Storage
    {
        public Guid StorageItemID { get; set; }

        public int Quantity { get; set; }

        public virtual ICollection<ProductParameter> ProductParameters { get; set; }
    }
}
