using DataMatrix_secondTestTask.Models;
using DataMatrix_secondTestTask.Repositories;

namespace DataMatrix_secondTestTask.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetPaged(int page, int pageSize);
        Task<Order?> AddOrder(Order contactUser);
        Task<string> DeleteOrder(int id);
    }
}
