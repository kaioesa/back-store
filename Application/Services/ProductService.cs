namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductById(Guid id)
        {
            Product result = await _productRepository.GetProductById(id);

            return result;
        }
        public async Task<Product> GetProductByName(string name)
        {
            Product result = await _productRepository.GetProductByName(name);
            return result;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> result = await _productRepository.GetAllProducts();
            return result;
        }

        public async Task<Product> CreateProduct(Product product)
        {
            var createdProduct = Product.Create(
                product
                );

            await _productRepository.CreateProduct(createdProduct);

            return createdProduct;
        }

        public async Task DeleteProduct(Guid id)
        {
            await _productRepository.DeleteProduct(id);
        }

        public async Task<Product> UpdateProduct(Product product)
        {

            var result = await _productRepository.UpdateProduct(product);

            return result;
        }
    }
}