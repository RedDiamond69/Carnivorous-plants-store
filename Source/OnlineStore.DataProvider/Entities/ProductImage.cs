using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductImage
    {
        [Key]
        public string ProductImageId { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(250, ErrorMessage = "Image filename length cannot be more than 250.")]
        public string Filename { get; set; }

        [Required, ForeignKey("Product")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        public ProductImage()
        {
            ProductImageId = Guid.NewGuid().ToString();
            ProductId = Guid.NewGuid().ToString();
        }
    }
}
