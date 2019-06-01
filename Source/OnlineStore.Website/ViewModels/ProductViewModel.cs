using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.ViewModels
{
    public class ProductViewModel
    {
        public string ProductId { get; set; }

        public string CategoryId { get; set; }

        public string VendorCode { get; set; }

        public string ProductName { get; set; }

        public string ProductImageFilename { get; set; }

        public string ProductDescription { get; set; }

        public decimal Price { get; set; }

        public string StockId { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public DateTime ModifiedDate { get; set; }

        public ProviderViewModel Provider { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}