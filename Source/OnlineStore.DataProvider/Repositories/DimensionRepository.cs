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
    public class DimensionRepository : Repository<Dimension>, IDimensionRepository
    {
        public DimensionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
