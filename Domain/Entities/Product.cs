using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public int Stock { get; private set; }

        public void DecreaseStock(int quantity)
        {
            if (Stock >= quantity)
                Stock -= quantity;
            else
                throw new InvalidOperationException("Insufficient stock.");
        }

        public void IncreaseStock(int quantity)
        {
            Stock += quantity;
        }

        public void DecreasePrice(decimal price)
        {
            Price -= price;
        }

        public void IncreasePrice(decimal price)
        {
            Price += price;

        }

        public static Product Create(Product product) {
            if (string.IsNullOrEmpty(product.Name) && 
                string.IsNullOrEmpty(product.Description))
            {
                throw new ArgumentNullException("One or more parameters are invalid or missing!");
            }


            if (product.Price < 0 && product.Stock < 0) {
                throw new ArgumentOutOfRangeException(nameof(product.Price), "Product price cannot be negative");
            }

            return new Product {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Stock = product.Stock
            };
        }
    }
}
