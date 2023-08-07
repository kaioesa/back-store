namespace Domain.Entities
{
    public class Order
    {
        public User User { get; private set; }
        public Dictionary<int, int> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CreatedAt { get; private set; }

        public Order(User user, Dictionary<int, int> items, decimal total)
        {
            User = user;
            Items = items;
            TotalAmount = total;
            CreatedAt = DateTime.Now;
        }

        public void Checkout()
        {
            //foreach (var item in Items)
            //{
            //    Product product = ProductRepository.GetProductById(item.Key);
            //    product.DecreaseStock(item.Value);
            //}
            //OrderRepository.SaveOrder(this);
        }
    }
}
