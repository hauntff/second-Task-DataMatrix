using DataMatrix_secondTestTask.Data;
using DataMatrix_secondTestTask.Interfaces;
using DataMatrix_secondTestTask.Models;
using System;

namespace DataMatrix_secondTestTask.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Order>> GetPaged(int page, int perPage)
        {
            return await base.GetPaged(page, perPage);
        }
    }
}
