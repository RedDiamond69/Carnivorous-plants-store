using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Album
    {
        [Key]
        public Guid AlbumID { get; set; }

        [Required(ErrorMessage = "Album name is required."), 
            MaxLength(100, ErrorMessage = "Album name length cannot be more than 100.")]
        public string AlbumName { get; set; }

        [Required(ErrorMessage = "Album image filename is required."), 
            MaxLength(256, ErrorMessage = "Album filename length cannot be more than 256.")]
        public string AlbumImageFilename { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime ModifiedDate { get; set; }

        [Required(ErrorMessage = "Count is required.")]
        public int ImageCount { get; set; }

        public virtual ICollection<AlbumImage> AlbumImages { get; set; }

        public Album()
        {
            AlbumImages = new List<AlbumImage>();
        }
    }
}
