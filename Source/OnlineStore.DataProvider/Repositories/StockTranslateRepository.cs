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
    public class StockTranslateRepository : Repository<StockTranslate>, IStockTranslateRepository
    {
        public StockTranslateRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
