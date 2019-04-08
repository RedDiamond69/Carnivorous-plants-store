﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public int SeoAttributeID { get; set; }
        public virtual SeoAttribute SeoAttribute { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}