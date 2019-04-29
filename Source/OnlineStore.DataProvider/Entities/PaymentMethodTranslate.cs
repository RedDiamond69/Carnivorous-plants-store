using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class PaymentMethodTranslate
    {
        [Key]
        public string PaymentMethodTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("PaymentMethod")]
        public string PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(30, ErrorMessage = "Name length cannot be more than 30.")]
        public string MethodName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(200, ErrorMessage = "Description length cannot be more than 200.")]
        public string MethodDescription { get; set; }

        [Required]
        public bool Availability { get; set; }

        public PaymentMethodTranslate()
        {
            PaymentMethodTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            PaymentMethodId = Guid.NewGuid().ToString();
        }
    }
}
