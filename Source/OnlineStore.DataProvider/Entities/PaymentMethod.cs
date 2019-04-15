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
        public Guid MethodID { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(30, ErrorMessage = "Name length cannot be more than 30.")]
        public string MethodName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(200, ErrorMessage = "Description length cannot be more than 200.")]
        public string MethodDescription { get; set; }

        [Required]
        public bool Availability { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public PaymentMethod()
        {
            Payments = new List<Payment>();
        }
    }
}
