using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
{
    public class ProductDTO
    {
        public string ProductId { get; set; }

        public string VendorCode { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal Price { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ProductImageFilename { get; set; }

        public string ProviderId { get; set; }

        public string CategoryId { get; set; }

        public string StockId { get; set; }
    }
}
