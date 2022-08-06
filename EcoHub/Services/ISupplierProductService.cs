using EcoHub.Models;

namespace EcoHub.Services
{
    public interface ISupplierProductService
    {
        public Task<List<SupplierProduct>> GetAllProducts();
        public Task<SupplierProduct> GetProductById(int id);
        public Task<SupplierProduct> UpdateProduct(SupplierProduct supplier);
        public void AddNewProduct(SupplierProduct product);

    }
}
