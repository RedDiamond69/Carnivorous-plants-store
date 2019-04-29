using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ArticleTranslate
    {
        [Key]
        public string ArticleTranslateId { get; set; }

        [Required, ForeignKey("Article")]
        public string ArticleId { get; set; }
        public virtual Article Article { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Index("ArticleTitleIndex", IsUnique = true)]
        [Required(ErrorMessage = "Title is required."), MaxLength(250, ErrorMessage = "Title length cannot be more than 250.")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Text is required."), MaxLength(100000, ErrorMessage = "Text length cannot be more than 100000.")]
        public string ArticleText { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(200, ErrorMessage = "Page Description length cannot be more than 200.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        public ArticleTranslate()
        {
            ArticleTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            ArticleId = Guid.NewGuid().ToString();
        }
    }
}
