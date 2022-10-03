using MinimalAPI_CQRS_Mediator.Module.RouteModule;

namespace MinimalAPI_CQRS_Mediator.Endpoints.EndpointConfig
{
    public class ProductModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/products", () =>
            {
                return Results.BadRequest(new { message = "Product list" });

            });

            return endpoints;
        }
    }
}
