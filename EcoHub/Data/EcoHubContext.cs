using EcoHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcoHub.Data
{
    public class EcoHubContext : IdentityDbContext<User>
    {
        public EcoHubContext(DbContextOptions<EcoHubContext> options) : base(options) { }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
