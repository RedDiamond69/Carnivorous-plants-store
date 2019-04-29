using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class CategoryTranslate
    {
        [Key]
        public string CategoryTranslateId { get; set; }

        [Required, ForeignKey("Category")]
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(100, ErrorMessage = "Name length cannot be more than 100.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(500, ErrorMessage = "Description length cannot be more than 500.")]
        public string CategoryDescription { get; set; }

        [Required(ErrorMessage = "Page Description is required."), MaxLength(200, ErrorMessage = "Page Description length cannot be more than 200.")]
        public string PageDescription { get; set; }

        [Required(ErrorMessage = "Page Keywords is required."), MaxLength(100, ErrorMessage = "Page Keywords length cannot be more than 100.")]
        public string PageKeywords { get; set; }

        public CategoryTranslate()
        {
            CategoryTranslateId = Guid.NewGuid().ToString();
            CategoryId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
        }
    }
}
