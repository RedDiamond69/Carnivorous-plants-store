using System;

namespace OnlineStore.DataProvider.Entities
{
    public class AlbumImage
    {
        public Guid ImageID { get; set; }

        public string ImageFilename { get; set; }

        public Guid AlbumID { get; set; }
        public virtual Album Album { get; set; }
    }
}