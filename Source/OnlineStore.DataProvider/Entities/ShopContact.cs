using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ShopContact
    {
        [Key]
        public string ShopContactId { get; set; }

        [Required(ErrorMessage = "Mobile phone is required."), MaxLength(30, ErrorMessage = "Mobile phone cannot be more than 30.")]
        public string MobilePhone { get; set; }

        [Required(ErrorMessage = "Email is required."), MaxLength(200, ErrorMessage = "Email cannot be more than 200.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Work time is required."), MaxLength(200, ErrorMessage = "Work time length cannot be more than 200.")]
        public string WorkTime { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ShopContactTranslate> ShopContactTranslates { get; set; }

        public ShopContact()
        {
            ShopContactId = Guid.NewGuid().ToString();
            ShopContactTranslates = new List<ShopContactTranslate>();
        }
    }
}
