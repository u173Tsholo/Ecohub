using EcoHub.Models;

namespace EcoHub.Services
{
    public interface ICustomerProductService
    {
        public Task<List<SupplierProduct>> GetAllProducts();
        public Task<SupplierProduct> GetProductById(int id);
        public Task<List<SupplierProduct>> GetAllProductsBySupplier();

        //	Get all products
        //	Get products by supplier

    }
}
