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

        public ProductTranslate()
        {
            ProductTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            ProductId = Guid.NewGuid().ToString();
        }
    }
}
