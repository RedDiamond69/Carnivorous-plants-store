using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(250, ErrorMessage = "Image filename length cannot be more than 250.")]
        public string ProductImageFilename { get; set; }

        public virtual Storage Storage { get; set; }

        [ForeignKey("Provider")]
        public string ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public virtual Category Category{ get; set; }

        [ForeignKey("Stock")]
        public string StockId { get; set; }
        public virtual Stock Stock { get; set; }

        public virtual ProductInformation ProductInformation { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductParameter> ProductParameters { get; set; }
        public virtual ICollection<ProductTranslate> ProductTranslates { get; set; }

        public Product()
        {
            ProductId = Guid.NewGuid().ToString();
            CategoryId = Guid.NewGuid().ToString();
            ProviderId = Guid.NewGuid().ToString();
            StockId = Guid.NewGuid().ToString();
            ProductImages = new List<ProductImage>();
            ProductParameters = new List<ProductParameter>();
            ProductTranslates = new List<ProductTranslate>();
        }
    }
}
