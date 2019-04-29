using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class PaymentMethod
    {
        [Key]
        public string MethodId { get; set; }

        [Required(ErrorMessage = "Image is required."), MaxLength(250, ErrorMessage = "Filename length cannot be more than 250.")]
        public string MethodImageFilename { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PaymentMethodTranslate> PaymentMethodTranslates { get; set; }

        public PaymentMethod()
        {
            MethodId = Guid.NewGuid().ToString();
            Payments = new List<Payment>();
            PaymentMethodTranslates = new List<PaymentMethodTranslate>();
        }
    }
}
