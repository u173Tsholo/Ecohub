using EcoHub.Models;
using EcoHub.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcoHub.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SupplierProductController : Controller
    {
        private readonly ISupplierProductService _supplierProduct;
        public SupplierProductController(ISupplierProductService supplierProductService)
        {
            _supplierProduct = supplierProductService;
        }

        [HttpGet(Name = "GetAllProductsByEmail")]
        public async Task<List<SupplierProduct>> GetAllProductsBySupplier(string email)
        {
            return await _supplierProduct.GetAllProductsBySupplier(email);
        }

        [HttpPost(Name = "AddNewProduct")]
        public void AddNewProduct(SupplierProduct supplierProduct)
        {
            _supplierProduct.AddNewProduct(supplierProduct);
        }

    }
}
