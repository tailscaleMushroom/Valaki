using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Valaki.Application.Repositories;
using Valaki.Persistence.Context;
using Valaki.Persistence.Repositories;

namespace Valaki.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IKiteSpotRepository, KiteSpotRepository>();
        }
    }
}
