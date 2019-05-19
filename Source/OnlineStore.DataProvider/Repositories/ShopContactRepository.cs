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
    public class ShopContactRepository : Repository<ShopContact>, IShopContactRepository
    {
        public ShopContactRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
