using EcoHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoHub.Data
{
    public class EcoHubContext : DbContext
    {
        public EcoHubContext(DbContextOptions options) : base(options) { }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
