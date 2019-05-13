using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
{
    public class ProductParameterDTO
    {
        public string ProductParameterId { get; set; }

        public string DimensionName { get; set; }

        public string DimensionDescription { get; set; }

        public decimal PriceIncrease { get; set; }

        public bool Availability { get; set; }

        public string ProductId { get; set; }
    }
}
