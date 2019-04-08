using System.Collections.Generic;

namespace OnlineStore.DataProvider.Entities
{
    public class DeliveryType
    {
        public int DeliveryTypeID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool Availability { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}