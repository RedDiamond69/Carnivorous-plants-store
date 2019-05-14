using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}