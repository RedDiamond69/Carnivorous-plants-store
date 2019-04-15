using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; }

        [Required, ForeignKey("PaymentMethodID")]
        public Guid PaymentMethodID { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        [Required]
        public virtual Order Order { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public decimal Sum { get; set; }
    }
}
