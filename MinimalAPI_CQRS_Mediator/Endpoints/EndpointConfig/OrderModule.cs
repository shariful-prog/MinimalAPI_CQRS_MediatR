using MinimalAPI_CQRS_Mediator.Module.RouteModule;

namespace MinimalAPI_CQRS_Mediator.Module.EndpointModule
{
    public class OrderModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/orders", () =>
            {
                return "Hello Orders";
            });
            endpoints.MapPost("/orders", () =>
            {

            });
            return endpoints;
        }

        public IServiceCollection RegisterModule(IServiceCollection services)
        {
            // dependency Injection 
            //services.AddSingleton(new OrderConfig());
            //services.AddScoped<IOrdersRepository, OrdersRepository>();
            //services.AddScoped<ICustomersRepository, CustomersRepository>();
            //services.AddScoped<IPayment, PaymentService>();
            return services;
        }
    }
}
