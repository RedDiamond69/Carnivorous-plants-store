using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Payment
    {
        public Guid PaymentID { get; set; }

        public Guid PaymentMethodID { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual Order Order { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Sum { get; set; }
    }
}
