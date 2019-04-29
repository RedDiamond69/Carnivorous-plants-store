using OnlineStore.DataProvider.Context;
using OnlineStore.DataProvider.Entities;
using OnlineStore.DataProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Repositories
{
    public class ProductTranslateRepository : Repository<ProductTranslate>, IProductTranslateRepository
    {
        public ProductTranslateRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
