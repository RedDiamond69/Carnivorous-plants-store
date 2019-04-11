using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
