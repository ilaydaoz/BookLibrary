using BookLibrary.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Diagnostics;

namespace BookLibrary.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BLDbContext>(x =>
            {
                x.UseNpgsql(configuration.GetConnectionString("BLDbContext"))
                .LogTo(x => Debug.WriteLine(x));
                x.EnableSensitiveDataLogging();
            });
            services.TryAddScoped<DbContext, BLDbContext>();
        }
    }
}