using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Article
    {
        [Key]
        public string ArticleId { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(250, ErrorMessage = "Image filename length cannot be more than 250.")]
        public string ImageFilename { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime DateTime { get; set; }

        [Required, ForeignKey("Category")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<ArticleTranslate> ArticleTranslates { get; set; }

        public Article()
        {
            ArticleId = Guid.NewGuid().ToString();
            CategoryId = Guid.NewGuid().ToString();
        }
    }
}
