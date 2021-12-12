using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection service, IConfiguration configuration) =>
            service.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
