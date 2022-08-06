using EcoHub.Data;
using EcoHub.Models;

namespace EcoHub.Services
{
    public class SupplierProductService : ISupplierProductService
    {
        private readonly EcoHubContext db;
        public void AddNewProduct(SupplierProduct product)
        {
            if (product != null)
            {
                db.SupplierProducts.Add(product);
                db.SaveChanges();
            }
        }

        public async Task<List<SupplierProduct>> GetAllProducts()
        {
            return db.SupplierProducts.ToList();
        }

        public async Task<SupplierProduct> GetProductById(int id)
        {
            return await db.SupplierProducts.FindAsync(id);
        }

        public Task<SupplierProduct> UpdateProduct(SupplierProduct supplier)
        {
            throw new NotImplementedException();
        }
    }
}
