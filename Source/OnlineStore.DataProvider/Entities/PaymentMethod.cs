using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class PaymentMethod
    {
        public int MethodID { get; set; }

        public string MethodName { get; set; }

        public string MethodDescription { get; set; }

        public bool Availability { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
