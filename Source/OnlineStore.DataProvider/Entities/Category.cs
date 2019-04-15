using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryID { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(100, ErrorMessage = "Name length cannot be more than 100.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(500, ErrorMessage = "Description length cannot be more than 500.")]
        public string CategoryDescription { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(100, ErrorMessage = "Page Description length cannot be more than 100.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
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
