using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("VenusFlyTrapOnlineShop") { }
    }
}
