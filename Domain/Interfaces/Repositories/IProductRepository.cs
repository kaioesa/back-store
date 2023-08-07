namespace Domain.Interfaces.Repositories

{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(Guid id);
        Task<Product> GetProductByName(string name);
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProduct(Guid id);
    }
}
