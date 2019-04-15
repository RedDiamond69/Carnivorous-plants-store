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
        public Guid ProductID { get; set; }

        [Required(ErrorMessage = "Vendor code is required."), MaxLength(5, ErrorMessage = "Vendor code length cannot be more than 5.")]
        public string VendorCode { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(50, ErrorMessage = "Name length cannot be more than 50.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(5000, ErrorMessage = "Description length cannot be more than 5000.")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(256, ErrorMessage = "Image filename length cannot be more than 256.")]
        public string ProductImageFilename { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(100, ErrorMessage = "Page Description length cannot be more than 100.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        [Required, ForeignKey("ProviderID")]
        public Guid ProviderID { get; set; }
        public virtual Provider Provider { get; set; }

        [Required, ForeignKey("CategoryID")]
        public Guid CategoryID { get; set; }
        public virtual Category Category{ get; set; }

        [ForeignKey("StockID")]
        public Guid? StockID { get; set; }
        public virtual Stock Stock { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductParameter> ProductParameters { get; set; }

        public Product()
        {
            ProductImages = new List<ProductImage>();
            ProductParameters = new List<ProductParameter>();
        }
    }
}
