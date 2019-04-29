using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DataProvider.Entities
{
    public class AlbumImage
    {
        [Key]
        public string ImageId { get; set; }

        [Required(ErrorMessage = "Filename is required."), MaxLength(250, ErrorMessage = "Filename length cannot be more than 250.")]
        public string ImageFilename { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime AddedDate { get; set; }

        [Required, ForeignKey("Album")]
        public string AlbumId { get; set; }
        public virtual Album Album { get; set; }

        public virtual ICollection<AlbumImageTranslate> AlbumImageTranslates { get; set; }

        public AlbumImage()
        {
            ImageId = Guid.NewGuid().ToString();
            AlbumId = Guid.NewGuid().ToString();
            AlbumImageTranslates = new List<AlbumImageTranslate>();
        }
    }
}