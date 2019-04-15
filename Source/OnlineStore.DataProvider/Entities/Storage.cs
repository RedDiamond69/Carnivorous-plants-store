using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Storage
    {
        [Key]
        public Guid StorageItemID { get; set; }

        [Required]
        public int Quantity { get; set; }

        public virtual ProductParameter ProductParameter { get; set; }
    }
}
