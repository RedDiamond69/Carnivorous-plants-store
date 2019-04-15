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
        public Guid ArticleID { get; set; }

        [Required(ErrorMessage = "Title is required."), MaxLength(250, ErrorMessage = "Title length cannot be more than 250.")]
        public string ArticleTitle { get; set; }

        [Required(ErrorMessage = "Text is required."), MaxLength(100000, ErrorMessage = "Text length cannot be more than 100000.")]
        public string ArticleText { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(256, ErrorMessage = "Image filename length cannot be more than 256.")]
        public string ImageFilename { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(100, ErrorMessage = "Page Description length cannot be more than 100.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        [Required, ForeignKey("CategoryID")]
        public Guid? CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
