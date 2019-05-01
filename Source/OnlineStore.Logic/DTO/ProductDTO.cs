using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.DTO
{
    public class ProductDTO
    {
        public string ProductId { get; set; }

        public string VendorCode { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ProductImageFilename { get; set; }

        public ProviderDTO Provider { get; set; }

        public CategoryDTO Category { get; set; }

        public StockDTO Stock { get; set; }

        public IEnumerable<ProductImageDTO> ProductImages { get; set; }

        public IEnumerable<ProductParameterDTO> ProductParameters { get; set; }
    }
}
