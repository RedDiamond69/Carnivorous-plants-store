using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ExchangeRate
    {
        [Key]
        public string ExchangeRateId { get; set; }

        [Required, MaxLength(3, ErrorMessage = "Abbreviation length cannot be more than 3.")]
        public string ExchangeAbbreviation { get; set; }

        [Required(ErrorMessage = "Rate is required.")]
        public decimal CurrentRate { get; set; }

        public ExchangeRate()
        {
            ExchangeRateId = Guid.NewGuid().ToString();
        }
    }
}
