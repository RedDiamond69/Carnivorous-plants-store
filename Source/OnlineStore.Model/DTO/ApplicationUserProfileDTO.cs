using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
{
    public class ApplicationUserProfileDTO
    {
        public string ApplicationUserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public string ImageFilename { get; set; }
    }
}
