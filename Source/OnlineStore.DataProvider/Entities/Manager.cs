using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Manager
    {
        public Guid ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
