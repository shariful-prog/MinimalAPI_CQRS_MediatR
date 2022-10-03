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
    }
}
