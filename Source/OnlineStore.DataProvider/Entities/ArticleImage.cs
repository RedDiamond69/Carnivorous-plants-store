namespace OnlineStore.DataProvider.Entities
{
    public class ArticleImage
    {
        public int ArticleImageID { get; set; }

        public string Filename { get; set; }

        public int ArticleID { get; set; }
        public Article Article { get; set; }
    }
}