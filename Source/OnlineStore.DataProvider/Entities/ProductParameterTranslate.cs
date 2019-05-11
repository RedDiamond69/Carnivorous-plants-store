using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductParameterTranslate
    {
        [Key]
        public string ProductParameterTranslateId { get; set; }

        [Required, ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        [Required, ForeignKey("ProductParameter")]
        public string ProductParameterId { get; set; }
        public virtual ProductParameter ProductParameter { get; set; }

        [Required]
        public decimal PriceIncrease { get; set; }

        public ProductParameterTranslate()
        {
            ProductParameterTranslateId = Guid.NewGuid().ToString();
            LanguageId = Guid.NewGuid().ToString();
            ProductParameterId = Guid.NewGuid().ToString();
        }
    }
}
