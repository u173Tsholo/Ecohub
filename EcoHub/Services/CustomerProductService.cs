using EcoHub.Data;
using EcoHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoHub.Services
{
    public interface CustomerProductService : ICustomerProductService
    {
        private readonly EcoHubContext db;

        public CustomerProductService(EcoHubContext dbContext)
        {
            db = dbContext;
        }
        public async Task<List<SupplierProduct>> GetAllProductsBySupplier(SupplierProduct supplierProduct)
        {
            var supplierProductsList =
                await db.SupplierProducts.Where(supp => supp.User.Id == supplierProduct.User.Id).ToListAsync();
            return supplierProductsList;
        }

        public async Task<SupplierProduct> GetProductById(int id) { 
            return await db.SupplierProducts.FindAsync(id);
        }
        public async Task<List<SupplierProduct>> GetAllProducts() {
            return await db.SupplierProducts.ToListAsync();
        }
    }
}
