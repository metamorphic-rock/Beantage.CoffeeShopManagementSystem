using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Application.Services;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Repository;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Add db conection
builder.Services.ImplementPersistance(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
