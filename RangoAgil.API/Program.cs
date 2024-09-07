using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    o => o.UseSqlite(builder.Configuration["ConnectionStrings.RangoDbConnectionStr"])
);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/rangos/{numero}", (int numero) =>
{
    return "Passou no teste" + " - " +  numero;
});

app.MapGet("/rangos", () =>
{
    return "Passou no teste" ;
});





app.Run();


