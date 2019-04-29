﻿using OnlineStore.DataProvider.Context;
using OnlineStore.DataProvider.Entities;
using OnlineStore.DataProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Repositories
{
    public class ProductInformationRepository : Repository<ProductInformation>, IProductInformationRepository
    {
        public ProductInformationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
