using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public string VendorCode { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int ProviderID { get; set; }
        public Provider Provider { get; set; }

        public int CategoryID { get; set; }
        public Category Category{ get; set; }

        public int SeoAttributeID { get; set; }
        public virtual SeoAttribute SeoAttribute { get; set; }

        public int StockID { get; set; }
        public Stock Stock { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductParameter> ProductParameters { get; set; }
    }
}
