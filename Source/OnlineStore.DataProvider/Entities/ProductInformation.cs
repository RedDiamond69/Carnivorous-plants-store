using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ProductInformation
    {
        [Key, ForeignKey("Product")]
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Index("VendorCodeIndex", IsUnique = true)]
        [Required(ErrorMessage = "Vendor code is required."), MaxLength(5, ErrorMessage = "Vendor code length cannot be more than 5.")]
        public string VendorCode { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductInformationTranslate> ProductInformationTranslates { get; set; }

        public ProductInformation()
        {
            ProductId = Guid.NewGuid().ToString();
            ProductInformationTranslates = new List<ProductInformationTranslate>();
        }
    }
}
