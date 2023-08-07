using Domain.Entities;
using Infrastructure.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> GetProductById(Guid id)
        {
            var result = await _dbContext.Products.FindAsync(id);

            if (result == null)
            {
                throw new NotFoundException($"Product with ID {id} was not found.");
            }

            return result;
        }

        public async Task<Product> GetProductByName(string name)
        {
            var result = await _dbContext.Products.FirstOrDefaultAsync(p =>
                p.Name.ToLower() == name.ToLower()
            );

            if (result == null)
            {
                throw new NotFoundException($"Product with Name {name} was not found.");
            }

            return result;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }
        public async Task<Product> CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            try
            {
                _dbContext.Products.Update(product);
                await _dbContext.SaveChangesAsync();
                return product;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException("It wasnt possible to update the product", ex);
            }
        }

        public async Task DeleteProduct(Guid id)
        {
            var product = await _dbContext.Products.FindAsync(id);

            if (product != null)
            {
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotFoundException($"Product with ID {id} not found.");
            }
        }


    }
}
