using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Provider
    {
        [Key]
        public string ProviderId { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(250, ErrorMessage = "Image filename length cannot be more than 250.")]
        public string ImageFilename { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProviderTranslate> ProviderTranslates { get; set; }

        public Provider()
        {
            ProviderId = Guid.NewGuid().ToString();
            Products = new List<Product>();
            ProviderTranslates = new List<ProviderTranslate>();
        }
    }
}
