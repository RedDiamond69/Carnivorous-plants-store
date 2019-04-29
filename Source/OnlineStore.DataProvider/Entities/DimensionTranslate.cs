using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class DimensionTranslate
    {
        [Key]
        public string DimensionTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("Dimension")]
        public string DimensionId { get; set; }
        public virtual Dimension Dimension { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(10, ErrorMessage = "Name length cannot be more than 10.")]
        public string DimensionName { get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(200, ErrorMessage = "Description length cannot be more than 200.")]
        public string DimensionDescription { get; set; }

        public DimensionTranslate()
        {
            DimensionTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            DimensionId = Guid.NewGuid().ToString();
        }
    }
}
