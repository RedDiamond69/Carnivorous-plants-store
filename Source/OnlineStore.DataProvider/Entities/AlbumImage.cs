using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DataProvider.Entities
{
    public class AlbumImage
    {
        [Key]
        public Guid ImageID { get; set; }

        [Required(ErrorMessage = "Filename is required."), MaxLength(256, ErrorMessage = "Filename length cannot be more than 256.")]
        public string ImageFilename { get; set; }

        [Required, ForeignKey("AlbumID")]
        public Guid AlbumID { get; set; }
        public virtual Album Album { get; set; }
    }
}