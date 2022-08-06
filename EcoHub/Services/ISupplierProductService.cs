using EcoHub.Models;

namespace EcoHub.Services
{
    public interface ISupplierProductService
    {
        public Task<List<SupplierProduct>> GetAllProductsBySupplier(SupplierProduct supplierProduct);
        public Task<SupplierProduct> GetProductById(int id);
        public Task<string> UpdateProduct(SupplierProduct supplier);
        public void AddNewProduct(SupplierProduct product);

    }
}
