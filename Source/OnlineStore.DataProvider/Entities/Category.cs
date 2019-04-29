using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }

        [Required(ErrorMessage = "Image is required."), MaxLength(250, ErrorMessage = "Filename length cannot be more than 250.")]
        public string CategoryImageFilename { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime ModifiedDate { get; set; }

        [Required(ErrorMessage = "Products count is required.")]
        public int ProductsCount { get; set; }

        [Required(ErrorMessage = "Articles count is required.")]
        public int ArticlesCount { get; set; }

        [ForeignKey("Stock")]
        public string StockId { get; set; }
        public virtual Stock Stock { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual ICollection<CategoryTranslate> CategoryTranslates { get; set; }

        public Category()
        {
            CategoryId = Guid.NewGuid().ToString();
            StockId = Guid.NewGuid().ToString();
            Products = new List<Product>();
            Articles = new List<Article>();
            CategoryTranslates = new List<CategoryTranslate>();
        }
    }
}
