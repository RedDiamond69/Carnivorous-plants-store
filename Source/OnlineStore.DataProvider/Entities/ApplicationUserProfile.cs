using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ApplicationUserProfile
    {
        public Guid ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public string ImageFilename { get; set; }
    }
}
