using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string AlbumName { get; set; }

        public string AlbumImageFilename { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ImageCount { get; set; }

        public ICollection<AlbumImages> AlbumImages { get; set; }
    }
}
