using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.ViewModels
{
    public class CatalogPageViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public List<ProductViewModel> Products { get; set; }

        public List<LanguageViewModel> Languages { get; set; }

        public ShopContactViewModel Contacts { get; set; }
    }
}