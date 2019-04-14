using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class PaymentMethod
    {
        public Guid MethodID { get; set; }

        public string MethodName { get; set; }

        public string MethodDescription { get; set; }

        public bool Availability { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
