using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
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

        public string StockId { get; set; }

        public int ProductsCount { get; set; }

        public int ArticlesCount { get; set; }
    }
}
