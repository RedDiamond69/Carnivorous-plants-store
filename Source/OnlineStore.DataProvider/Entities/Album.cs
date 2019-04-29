using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Album
    {
        [Key]
        public string AlbumId { get; set; }

        [Required(ErrorMessage = "Album image filename is required."), 
            MaxLength(250, ErrorMessage = "Album filename length cannot be more than 250.")]
        public string AlbumImageFilename { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime ModifiedDate { get; set; }

        [Required(ErrorMessage = "Count is required.")]
        public int ImageCount { get; set; }

        public virtual ICollection<AlbumImage> AlbumImages { get; set; }
        public virtual ICollection<AlbumTranslate> AlbumTranslates { get; set; }

        public Album()
        {
            AlbumId = Guid.NewGuid().ToString();
            AlbumImages = new List<AlbumImage>();
            AlbumTranslates = new List<AlbumTranslate>();
        }
    }
}
