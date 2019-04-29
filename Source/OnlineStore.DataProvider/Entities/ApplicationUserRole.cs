using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ApplicationUserRole : IdentityRole
    {
        public ApplicationUserRole() : base()
        {
        }

        public ApplicationUserRole(string roleName) : base(roleName)
        {
        }
    }
}
