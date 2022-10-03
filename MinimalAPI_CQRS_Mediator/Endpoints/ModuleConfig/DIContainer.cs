using DATAMODEL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MinimalAPI_CQRS_Mediator.Endpoints.ModuleConfig
{
    public static class DIContainer
    {
        public static object RegisterDependency(this IServiceCollection services)
        {
            return services;
        }
    }
}
