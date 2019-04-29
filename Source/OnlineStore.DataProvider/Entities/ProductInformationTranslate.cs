using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductInformationTranslate
    {
        [Key]
        public string ProductInformationTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("ProductInformation")]
        public string ProductInformationId { get; set; }
        public virtual ProductInformation ProductInformation { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(5000, ErrorMessage = "Description length cannot be more than 5000.")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(100, ErrorMessage = "Page Description length cannot be more than 100.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        public ProductInformationTranslate()
        {
            ProductInformationTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            ProductInformationId = Guid.NewGuid().ToString();
        }
    }
}
