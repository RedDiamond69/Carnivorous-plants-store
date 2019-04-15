using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class DeliveryInformation
    {
        [Key]
        public Guid DeliveryInformationID { get; set; }

        [Required(ErrorMessage = "Default is required.")]
        public bool IsDefault { get; set; }

        [Required(ErrorMessage = "Country is required."), MaxLength(150, ErrorMessage = "Country length cannot be more than 150.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Region is required."), MaxLength(150, ErrorMessage = "Region length cannot be more than 150.")]
        public string Region { get; set; }

        [Required(ErrorMessage = "Sity is required."), MaxLength(150, ErrorMessage = "Sity length cannot be more than 150.")]
        public string Sity { get; set; }

        [Required(ErrorMessage = "Street is required."), MaxLength(150, ErrorMessage = "Street length cannot be more than 150.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "House is required."), MaxLength(150, ErrorMessage = "House length cannot be more than 150.")]
        public string House { get; set; }

        [Required(ErrorMessage = "Apartment is required."), MaxLength(10, ErrorMessage = "Apartment length cannot be more than 10.")]
        public string Apartment { get; set; }

        [Required, ForeignKey("CustomerID")]
        public Guid CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public DeliveryInformation()
        {
            Orders = new List<Order>();
        }
    }
}
