using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class StockTranslate
    {
        [Key]
        public string StockTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("Stock")]
        public string StockId { get; set; }
        public virtual Stock Stock { get; set; }

        [Required(ErrorMessage = "Title is required."), MaxLength(100, ErrorMessage = "Title length cannot be more than 100.")]
        public string StockTitle { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(200, ErrorMessage = "Description length cannot be more than 200.")]
        public string StockDescription { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(250, ErrorMessage = "Image filename length cannot be more than 250.")]
        public string ImageFilename { get; set; }

        public StockTranslate()
        {
            StockTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            StockId = Guid.NewGuid().ToString();
        }
    }
}
