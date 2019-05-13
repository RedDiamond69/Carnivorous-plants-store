using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
{
    public class ArticleDTO
    {
        public string ArticleId { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleText { get; set; }

        public string PageDescription { get; set; }

        public string PageKeywords { get; set; }

        public string ImageFilename { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CategoryId { get; set; }
    }
}
