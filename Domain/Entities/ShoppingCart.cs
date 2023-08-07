using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShoppingCart
    {
        public User User { get; private set; }
        private Dictionary<Guid, int> items = new Dictionary<Guid, int>();

        public ShoppingCart(User user)
        {
            User = user;
        }

        public void AddItem(Product product, int quantity)
        {
            if (items.ContainsKey(product.Id))
                items[product.Id] += quantity;
            else
                items[product.Id] = quantity;
        }

        public void RemoveItem(Product product, int quantity)
        {
            if (items.ContainsKey(product.Id))
            {
                items[product.Id] -= quantity;
                if (items[product.Id] <= 0)
                    items.Remove(product.Id);
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            //foreach (var item in items)
            //{
            //    Product product = ProductRepository.GetProductById(item.Key);
            //    total += product.Price * item.Value;
            //}
            return total;
        }
    }
}
