using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dependencies.ServiceDI.ContextDI
{
    public static class DBService
    {
        public static IServiceCollection AddContexts(this IServiceCollection services)
        {
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();

            services.AddDbContextPool<MyContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("MyConnection"))
                   .UseLazyLoadingProxies(); // Use Lazy Loading if required
            });

            return services;
        }
    }
}
