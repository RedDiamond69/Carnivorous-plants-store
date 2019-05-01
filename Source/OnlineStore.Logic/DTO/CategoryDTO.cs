using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Logic.DTO
{
    public class CategoryDTO
    {
        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public string CategoryImageFilename { get; set; }

        public DateTime ModifiedDate { get; set; }

        public StockDTO Stock { get; set; }

        public int ProductsCount { get; set; }

        public int ArticlesCount { get; set; }

        public IEnumerable<ProductDTO> Products { get; set; }

        public IEnumerable<ArticleDTO> Articles { get; set; }
    }
}
