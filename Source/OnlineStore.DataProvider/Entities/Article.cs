using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleText { get; set; }

        public string ImageFilename { get; set; }

        public DateTime DateTime { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
