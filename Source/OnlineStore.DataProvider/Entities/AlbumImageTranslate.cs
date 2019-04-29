using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class AlbumImageTranslate
    {
        [Key]
        public string AlbumImageTranslateId { get; set; }

        [Required, ForeignKey("AlbumImage")]
        public string AlbumImageId { get; set; }
        public virtual AlbumImage AlbumImage { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(150, ErrorMessage = "Description length cannot be more than 150.")]
        public string Description { get; set; }

        public AlbumImageTranslate()
        {
            AlbumImageTranslateId = Guid.NewGuid().ToString();
            AlbumImageId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
        }
    }
}
