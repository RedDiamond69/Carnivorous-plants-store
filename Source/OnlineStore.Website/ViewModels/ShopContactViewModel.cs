using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.ViewModels
{
    public class ShopContactViewModel
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