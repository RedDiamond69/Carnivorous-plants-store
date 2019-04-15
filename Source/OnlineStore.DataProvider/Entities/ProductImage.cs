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
        public Guid ProductImageID { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(256, ErrorMessage = "Image filename length cannot be more than 256.")]
        public string Filename { get; set; }

        [Required, ForeignKey("ProductID")]
        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
