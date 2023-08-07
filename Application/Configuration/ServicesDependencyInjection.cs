using Application.Services;
using Infrastructure.Persistence.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Configurations
{
    public class ServicesDependencyInjection
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IShoppingCartService, ShoppingCartService>();
            //services.AddScoped<IOrderService, OrderService>();

            services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
            //services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddDbContext<ApplicationDbContext>();
        }
    }
}
