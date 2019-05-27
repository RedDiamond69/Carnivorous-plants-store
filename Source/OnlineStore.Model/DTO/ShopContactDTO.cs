using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model.DTO
{
    public class ShopContactDTO
    {
        public string ShopContactId { get; set; }

        public string Location { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string WorkTime { get; set; }

        public string Registration { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
