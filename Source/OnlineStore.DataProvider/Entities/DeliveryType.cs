using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.DataProvider.Entities
{
    public class DeliveryType
    {
        [Key]
        public Guid DeliveryTypeID { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(150, ErrorMessage = "Name length cannot be more than 150.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(1000, ErrorMessage = "Description length cannot be more than 1000.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Availability is required.")]
        public bool Availability { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public DeliveryType()
        {
            Orders = new List<Order>();
        }
    }
}