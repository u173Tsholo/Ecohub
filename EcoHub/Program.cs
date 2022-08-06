using EcoHub.Data;
using EcoHub.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var connectionString = builder.Configuration.GetConnectionString(nameof(EcoHubContext));
builder.Services.AddDbContext<EcoHubContext>(options => options.UseNpgsql(connectionString));
//builder.Services.AddTransient<ISupplierProductService, SupplierProductService>();
//builder.Services.AddTransient<ICustomerProductService, CustomerProductService>();
//builder.Services.AddTransient<IUserManagementService, UserManagementService>();
builder.Services.AddTransient(x => new OrderNumberGenerator());

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
