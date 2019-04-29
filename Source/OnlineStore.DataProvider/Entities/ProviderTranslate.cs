using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProviderTranslate
    {
        [Key]
        public string ProviderTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("Provider")]
        public string ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(50, ErrorMessage = "Name length cannot be more than 50.")]
        public string ProviderName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(500, ErrorMessage = "Description length cannot be more than 500.")]
        public string ProviderDescription { get; set; }

        public ProviderTranslate()
        {
            ProviderTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            ProviderId = Guid.NewGuid().ToString();
        }
    }
}
