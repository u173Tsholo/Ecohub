using EcoHub.Data;
using EcoHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoHub.Services
{
    public class SupplierProductService : ISupplierProductService
    {
        private readonly EcoHubContext db;

        public SupplierProductService(EcoHubContext dbContext)
        {
            db = dbContext;
        }
        public void AddNewProduct(SupplierProduct product)
        {
            if (product != null)
            {
                db.SupplierProducts.Add(product);
                db.SaveChanges();
            }
        }

        public async Task<List<SupplierProduct>> GetAllProductsBySupplier(string email)
        {
            var supplierProductsList =
                await db.SupplierProducts.Where(supp => supp.User.NormalizedEmail == email).ToListAsync();
            return supplierProductsList;
        }

        public User GetUserById(int id)
        {
            User temp = db.Users.FirstOrDefault(u => u.Id == id);
            return null;
        }

        public async Task<SupplierProduct> GetProductByEmail(string email)
        {
            return await db.SupplierProducts.FindAsync(email);
        }

        public async Task<string> UpdateProduct(SupplierProduct product)
        {
            SupplierProduct exists = await db.SupplierProducts.FindAsync(product);
            if(exists != null)
            {
                exists.Name = product.Name;
                exists.Price = product.Price;
                exists.Approved = product.Approved;
                exists.Flagged = product.Flagged;
            }
            return "Updated";
        }

    }
}
