using Microsoft.EntityFrameworkCore;
using RangoAgil.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RangoDbContext>(
    o => o.UseSqlite(builder.Configuration["ConnectionStrings.RangoDbConnectionStr"]) 
);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
