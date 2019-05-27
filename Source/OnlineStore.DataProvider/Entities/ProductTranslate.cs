using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductTranslate
    {
        [Key]
        public string ProductTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("Product")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Index("ProductNameIndex", IsUnique = true)]
        [Required(ErrorMessage = "Name is required."), MaxLength(50, ErrorMessage = "Name length cannot be more than 50.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(5000, ErrorMessage = "Description length cannot be more than 5000.")]
        public string ProductDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(100, ErrorMessage = "Page Description length cannot be more than 100.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        public ProductTranslate()
        {
            ProductTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            ProductId = Guid.NewGuid().ToString();
        }
    }
}
