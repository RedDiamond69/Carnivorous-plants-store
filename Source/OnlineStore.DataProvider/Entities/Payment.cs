using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public int PaymentMethodID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Sum { get; set; }
    }
}
