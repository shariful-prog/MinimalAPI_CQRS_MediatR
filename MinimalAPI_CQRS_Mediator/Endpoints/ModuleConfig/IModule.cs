namespace MinimalAPI_CQRS_Mediator.Module.RouteModule
{
    public interface IModule
    {
        IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints);
    }
}
