using DAL.Context;
using Entity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Dependencies.ServiceDI.IdentityDI
{
    public static class IdentityCoreService
    {
        public static IServiceCollection AddIdentities(this IServiceCollection services)
        {
            // Add Identity services for AppUser and AppRole
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true; // You can configure more options here if needed
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 8;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
            })
            .AddEntityFrameworkStores<MyContext>() // Add the EF Core context for Identity
            .AddDefaultTokenProviders() // Adds default token providers like password reset tokens
            .AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider); // Custom token provider if needed

            return services;
        }
    }
}
