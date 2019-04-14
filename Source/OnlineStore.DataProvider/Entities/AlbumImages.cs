namespace OnlineStore.DataProvider.Entities
{
    public class AlbumImages
    {
        public int ImageID { get; set; }

        public string ImageFilename { get; set; }

        public int AlbumID { get; set; }
        public Album Album { get; set; }
    }
}