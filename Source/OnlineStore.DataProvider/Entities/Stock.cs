using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Stock
    {
        public int StockID { get; set; }

        public string StockTitle { get; set; }

        public string StockDescription { get; set; }

        public int Discount { get; set; }

        public string ImageFilename { get; set; }

        public int SeoAttributeID { get; set; }
        public virtual SeoAttribute SeoAttribute { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
