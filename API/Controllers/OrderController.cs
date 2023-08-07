using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet("/id")]
        public IActionResult GetOrderById(Guid id)
        {
            var result = _orderRepository.GetOrderById(id);
            return Ok(result);
        }
    }
}
