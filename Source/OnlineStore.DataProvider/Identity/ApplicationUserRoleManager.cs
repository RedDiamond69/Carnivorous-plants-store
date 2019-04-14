using Microsoft.AspNet.Identity;
using OnlineStore.DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Identity
{
    public class ApplicationUserRoleManager : RoleManager<ApplicationUserRole>
    {
        public ApplicationUserRoleManager(IRoleStore<ApplicationUserRole, string> store) : base(store)
        {
        }
    }
}
