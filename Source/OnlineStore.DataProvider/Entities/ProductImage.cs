using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductImage
    {
        public int ProductImageID { get; set; }

        public string Filename { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
