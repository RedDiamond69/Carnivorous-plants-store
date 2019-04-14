using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Product
    {
        public Guid ProductID { get; set; }

        public string VendorCode { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductImageFilename { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public Guid ProviderID { get; set; }
        public virtual Provider Provider { get; set; }

        public Guid CategoryID { get; set; }
        public virtual Category Category{ get; set; }

        public Guid? StockID { get; set; }
        public virtual Stock Stock { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductParameter> ProductParameters { get; set; }
    }
}
