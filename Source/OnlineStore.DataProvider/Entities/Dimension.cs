using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Dimension
    {
        [Key]
        public string DimensionId { get; set; }

        public virtual ICollection<DimensionTranslate> DimensionTranslates { get; set; }
        public virtual ICollection<ProductParameter> ProductParameters { get; set; }
        
        public Dimension()
        {
            DimensionId = Guid.NewGuid().ToString();
            DimensionTranslates = new List<DimensionTranslate>();
            ProductParameters = new List<ProductParameter>();
        }
    }
}
