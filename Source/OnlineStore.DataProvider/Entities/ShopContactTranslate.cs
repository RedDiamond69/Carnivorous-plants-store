using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ShopContactTranslate
    {
        [Key]
        public string ShopContactTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("ShopContact")]
        public string ShopContactId { get; set; }
        public virtual ShopContact ShopContact { get; set; }

        [Required(ErrorMessage = "Location is required."), MaxLength(200, ErrorMessage = "Location cannot be more than 200.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Registration is required."), MaxLength(300, ErrorMessage = "Registration cannot be more than 200.")]
        public string Registration { get; set; }

        public ShopContactTranslate()
        {
            ShopContactTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            ShopContactId = Guid.NewGuid().ToString();
        }
    }
}
