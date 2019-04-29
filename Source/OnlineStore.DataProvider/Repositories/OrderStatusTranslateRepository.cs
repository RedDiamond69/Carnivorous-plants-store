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
    public class OrderStatusTranslateRepository : Repository<OrderStatusTranslate>, IOrderStatusTranslateRepository
    {
        public OrderStatusTranslateRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
