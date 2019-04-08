using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class SeoAttribute
    {
        public int SeoAttributeID { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        public int StockID { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
