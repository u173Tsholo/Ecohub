using EcoHub.Data;
using EcoHub.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using EcoHub.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString(nameof(EcoHubContext));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
.AddEntityFrameworkStores<EcoHubContext>();

builder.Services.AddDbContext<EcoHubContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddTransient<ICustomerProductService, CustomerProductService>();
builder.Services.AddTransient<ISupplierProductService, SupplierProductService>();
builder.Services.AddTransient<IUserManagementService, UserManagementService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient(x => new OrderNumberGenerator());

builder.Services.AddControllers();
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
app.UseAuthentication();;


app.UseAuthorization();

app.MapControllers();

app.Run();
