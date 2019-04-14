﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Provider
    {
        public Guid ProviderID { get; set; }

        public string ProviderName { get; set; }

        public string ProviderDescription { get; set; }

        public string ImageFilename { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
