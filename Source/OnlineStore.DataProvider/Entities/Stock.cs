using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Stock
    {
        public Guid StockID { get; set; }

        public string StockTitle { get; set; }

        public string StockDescription { get; set; }

        public int Discount { get; set; }

        public string ImageFilename { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
