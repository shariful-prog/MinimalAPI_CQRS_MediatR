using DATAMODEL.DBContext;
using Microsoft.EntityFrameworkCore;
using MinimalAPI_CQRS_Mediator.Endpoints.ModuleConfig;
using MinimalAPI_CQRS_Mediator.Module.RouteModule;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));


builder.Services.RegisterModules();
builder.Services.RegisterDependency();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapEndpoints();
app.Run();
