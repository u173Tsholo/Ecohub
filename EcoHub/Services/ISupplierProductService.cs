using EcoHub.Models;

namespace EcoHub.Services
{
    public interface ISupplierProductService
    {
        public Task<List<SupplierProduct>> GetAllProductsBySupplier(string id);
        public Task<SupplierProduct> GetProductByEmail(string email);
        public Task<string> UpdateProduct(SupplierProduct supplier);
        public void AddNewProduct(SupplierProduct product);

    }
}
