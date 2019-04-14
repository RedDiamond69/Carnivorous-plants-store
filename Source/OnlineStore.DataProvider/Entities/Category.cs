using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Category
    {
        public Guid CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public Category()
        {
            Products = new List<Product>();
            Articles = new List<Article>();
        }
    }
}
