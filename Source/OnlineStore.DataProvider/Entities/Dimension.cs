using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Dimension
    {
        public Guid DimensionID { get; set; }

        public string DimensionName{ get; set; }

        public string DimensionDescription { get; set; }

        public virtual ICollection<ProductParameter> ProductParameters { get; set; }
    }
}
