using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductImage
    {
        public Guid ProductImageID { get; set; }

        public string Filename { get; set; }

        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
