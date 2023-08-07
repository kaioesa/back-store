using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
