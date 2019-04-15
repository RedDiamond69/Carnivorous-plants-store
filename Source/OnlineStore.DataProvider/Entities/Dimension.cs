using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Dimension
    {
        [Key]
        public Guid DimensionID { get; set; }

        [Required(ErrorMessage = "Name is required."), MaxLength(10, ErrorMessage = "Name length cannot be more than 10.")]
        public string DimensionName{ get; set; }

        [Required(ErrorMessage = "Description is required."), MaxLength(200, ErrorMessage = "Description length cannot be more than 200.")]
        public string DimensionDescription { get; set; }

        public virtual ICollection<ProductParameter> ProductParameters { get; set; }
        
        public Dimension()
        {
            ProductParameters = new List<ProductParameter>();
        }
    }
}
