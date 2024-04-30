using DataMatrix_secondTestTask.Models;
using DataMatrix_secondTestTask.Repositories;

namespace DataMatrix_secondTestTask.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IEnumerable<Order>> GetPaged(int page, int perPage);
    }
}
