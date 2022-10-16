using MinimalAPI_CQRS_Mediator.Module.RouteModule;

namespace MinimalAPI_CQRS_Mediator.Endpoints.EndpointConfig
{
    public class ProductModule : IModule
    {
        public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/products", () =>
            {
                int a = 20;
                if(a is >=20 && a<50) return Results.Ok(new { message = "Product list" });
                return Results.BadRequest(new { message = "Product list Error" });

            });

            return endpoints;
        }
    }
}
