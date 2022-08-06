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

        public async Task<List<SupplierProduct>> GetAllProductsBySupplier(SupplierProduct supplierProduct)
        {
            var supplierProductsList =
                await db.SupplierProducts.Where(supp => supp.User.Id == supplierProduct.User.Id).ToListAsync();
            return supplierProductsList;
        }

        public async Task<SupplierProduct> GetProductById(int id)
        {
            return await db.SupplierProducts.FindAsync(id);
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
