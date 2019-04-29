using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ApplicationUserProfile
    {
        [Key, ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(100, ErrorMessage = "Name length cannot be more than 100.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required."), MaxLength(150, ErrorMessage = "Surname length cannot be more than 150.")]
        public string Surname { get; set; }

        [MaxLength(150, ErrorMessage = "Patronymic length cannot be more than 150.")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(250, ErrorMessage = "Image filename length cannot be more than 250.")]
        public string ImageFilename { get; set; }

        public ApplicationUserProfile()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
