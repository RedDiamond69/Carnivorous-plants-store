using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Customer
    {
        [Key, ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<DeliveryInformation> DeliveryInformation { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Id = Guid.NewGuid().ToString();
            DeliveryInformation = new List<DeliveryInformation>();
            Orders = new List<Order>();
        }
    }
}
