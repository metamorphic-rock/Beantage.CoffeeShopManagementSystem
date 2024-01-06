using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection ImplementPersistance( this
        IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BeantageDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"),
            b => b.MigrationsAssembly(typeof(BeantageDbContext).Assembly.FullName)), ServiceLifetime.Transient);

        services.AddScoped<IBeantageDbContext>(provider =>
            provider.GetService<BeantageDbContext>());

        return services;
    }
}
