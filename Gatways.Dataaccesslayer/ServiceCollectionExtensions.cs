using Gatways.Dataaccesslayer.Infrastructure.IUnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Gatways.Dataaccesslayer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection _services { get; set; }
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }

        public static void AddDataLayerServices(this IServiceCollection services, string connectionString, IConfiguration configuration)
        {
            _services = services;
            AddDatabaseContext(connectionString);
        }

     
        public static void AddDatabaseContext(string connectionString)
        {
            _services.AddDbContext<GatewaysDbContext>(options =>
              options.UseSqlServer(connectionString));
        }

     
        public static IHost MigrateDatabaseToLatestVersion(this IHost host)
        {
            var serviceScopeFactory = (IServiceScopeFactory)host.Services.GetService(typeof(IServiceScopeFactory));

            using (var scope = serviceScopeFactory.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<GatewaysDbContext>();
                dbContext.Database.Migrate();
            }
            return host;
        }


    }

}
