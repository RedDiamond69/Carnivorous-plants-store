using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Stock
    {
        [Key]
        public Guid StockID { get; set; }

        [Required(ErrorMessage = "Title is required."), MaxLength(100, ErrorMessage = "Title length cannot be more than 100.")]
        public string StockTitle { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(200, ErrorMessage = "Description length cannot be more than 200.")]
        public string StockDescription { get; set; }

        [Required]
        public int Discount { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(256, ErrorMessage = "Image filename length cannot be more than 256.")]
        public string ImageFilename { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(100, ErrorMessage = "Page Description length cannot be more than 100.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Stock()
        {
            Products = new List<Product>();
        }
    }
}
