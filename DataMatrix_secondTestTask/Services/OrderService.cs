using DataMatrix_secondTestTask.Interfaces;
using DataMatrix_secondTestTask.Models;
using System.Text.RegularExpressions;

namespace DataMatrix_secondTestTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IEnumerable<Order>> GetPaged(int page, int pageSize)
        {
            var result = await _orderRepository.GetPaged(page, pageSize);
            return result;
        }

        public async Task<Order?> AddOrder(Order contactUser)
        {
            var result = await _orderRepository.Insert(contactUser);
            return result;
        }

        public async Task<string> DeleteOrder(int id)
        {
            var result = await _orderRepository.Delete(id);
            return result;
        }

    }
}
