using DataMatrix_secondTestTask.Interfaces;
using DataMatrix_secondTestTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataMatrix_secondTestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("paged")]
        public async Task <IActionResult> Get([FromQuery] int page, [FromQuery] int pageSize) 
        {
            var result = await _orderService.GetPaged(page,pageSize);
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] Order order)
        {
            var result = await _orderService.AddOrder(order);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _orderService.DeleteOrder(id);
            return Ok(result);
        }
    }
}
