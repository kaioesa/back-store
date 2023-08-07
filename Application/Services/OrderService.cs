namespace Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        //public async Task<Order> GetOrderById(Guid id)
        //{
        //    Order result = await _orderRepository.GetOrderById(id);
        //    return result;
        //}

        //public async Task<List<Order>> GetAllOrders()
        //{
        //    List<Order> result = await _orderRepository.GetAllOrders();
        //    return result;
        //}

        //public async Task<Order> CreateOrder(Dictionary<int, int> items, DateTime orderDate, decimal totalAmount, string user)
        //{
        //    var order = new Order
        //    {
        //        User = user,
        //        Items = items,
        //        TotalAmount = totalAmount,
        //        OrderDate = orderDate,
        //    };

        //    await _orderRepository.CreateOrder(order);
        //    return order;
        //}

        //public async Task DeleteOrder(Guid id)
        //{
        //    await _orderRepository.DeleteOrder(id);
        //}

        //public async Task<Order> UpdateOrder(Guid id, decimal totalAmount)
        //{
        //    var order = await _orderRepository.GetOrderById(id);

        //    if (order == null)
        //    {
        //        throw new NotFoundException($"Order with ID {id} not found.");
        //    }

        //    order.TotalAmount = totalAmount;
        //    await _orderRepository.UpdateOrder(order);
        //    return order;
        //}
    }

}
