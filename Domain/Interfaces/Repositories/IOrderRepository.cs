namespace Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrders();
        Task<Order> GetOrderById(Guid id);
        Task CreateOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(Guid id);
    }
}
