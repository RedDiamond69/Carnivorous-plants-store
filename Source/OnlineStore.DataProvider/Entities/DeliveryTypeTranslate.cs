using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class DeliveryTypeTranslate
    {
        [Key]
        public string DeliveryTypeTranslateId { get; set; }

        [Required, ForeignKey("DeliveryType")]
        public string DeliveryTypeId { get; set; }
        public virtual DeliveryType DeliveryType { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(150, ErrorMessage = "Name length cannot be more than 150.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(1000, ErrorMessage = "Description length cannot be more than 1000.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Availability is required.")]
        public bool Availability { get; set; }

        public DeliveryTypeTranslate()
        {
            DeliveryTypeTranslateId = Guid.NewGuid().ToString();
            DeliveryTypeId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
        }

    }
}
