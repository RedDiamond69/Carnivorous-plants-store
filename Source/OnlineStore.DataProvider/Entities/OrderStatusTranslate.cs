using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class OrderStatusTranslate
    {
        [Key]
        public string OrderStatusTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("OrderStatus")]
        public string OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(30, ErrorMessage = "Name length cannot be more than 30.")]
        public string StatusName { get; set; }

        public OrderStatusTranslate()
        {
            OrderStatusTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            OrderStatusId = Guid.NewGuid().ToString();
        }
    }
}
