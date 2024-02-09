using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Application.Services;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ISaleService, SaleService>();

// Add repositories to the container
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeRoleRepository, EmployeeRoleRepository>();
builder.Services.AddScoped<ISaleRepository, SaleRepository>();

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
