using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Provider
    {
        [Key]
        public Guid ProviderID { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(50, ErrorMessage = "Name length cannot be more than 50.")]
        public string ProviderName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(500, ErrorMessage = "Description length cannot be more than 500.")]
        public string ProviderDescription { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(256, ErrorMessage = "Image filename length cannot be more than 256.")]
        public string ImageFilename { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Provider()
        {
            Products = new List<Product>();
        }
    }
}
