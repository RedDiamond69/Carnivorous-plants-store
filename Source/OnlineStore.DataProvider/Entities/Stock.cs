using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Stock
    {
        [Key]
        public string StockId { get; set; }

        [Required]
        public int Discount { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Finish date is required.")]
        public DateTime FinishDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<StockTranslate> StockTranslates { get; set; } 

        public Stock()
        {
            StockId = Guid.NewGuid().ToString();
            Products = new List<Product>();
            StockTranslates = new List<StockTranslate>();
        }
    }
}
