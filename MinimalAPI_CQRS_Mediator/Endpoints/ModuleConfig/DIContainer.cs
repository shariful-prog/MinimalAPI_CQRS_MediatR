using Library.Models.AppUserManager;
using Library.Models.DBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MinimalAPI_CQRS_Mediator.Endpoints.ModuleConfig
{
    public static class DIContainer
    {
        public static object RegisterDependency(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
            return services;
        }
    }
}
