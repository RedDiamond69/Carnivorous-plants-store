using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class AlbumTranslate
    {
        [Key]
        public string AlbumTranslateId { get; set; }

        [Required, ForeignKey("Album")]
        public string AlbumId { get; set; }
        public virtual Album Album { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Index("AlbumNameIndex", IsUnique = true)]
        [Required(ErrorMessage = "Album name is required."),
            MaxLength(100, ErrorMessage = "Album name length cannot be more than 100.")]
        public string AlbumName { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(200, ErrorMessage = "Page Description length cannot be more than 200.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        public AlbumTranslate()
        {
            AlbumTranslateId = Guid.NewGuid().ToString();
            AlbumId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
        }
    }
}
