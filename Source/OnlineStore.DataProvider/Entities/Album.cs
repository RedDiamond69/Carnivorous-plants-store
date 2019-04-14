using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Album
    {
        public Guid AlbumID { get; set; }

        public string AlbumName { get; set; }

        public string AlbumImageFilename { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ImageCount { get; set; }

        public virtual ICollection<AlbumImage> AlbumImages { get; set; }

        public Album()
        {
            AlbumImages = new List<AlbumImage>();
        }
    }
}
