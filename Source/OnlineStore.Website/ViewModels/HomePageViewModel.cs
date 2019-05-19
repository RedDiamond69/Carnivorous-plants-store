using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.ViewModels
{
    public class HomePageViewModel
    {
        public List<CategoryViewModel> Categories { get; set; }

        public List<LanguageViewModel> Languages { get; set; }

        public ContactViewModel Contacts { get; set; }
    }
}