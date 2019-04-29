using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DataProvider.Entities
{
    public class DeliveryType
    {
        [Key]
        public string DeliveryTypeId { get; set; }

        [Required(ErrorMessage = "Image is required."), MaxLength(250, ErrorMessage = "Filename length cannot be more than 250.")]
        public string DeliveryTypeImageFilename { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<DeliveryTypeTranslate> DeliveryTypeTranslates { get; set; }

        public DeliveryType()
        {
            DeliveryTypeId = Guid.NewGuid().ToString();
            Orders = new List<Order>();
            DeliveryTypeTranslates = new List<DeliveryTypeTranslate>();
        }
    }
}