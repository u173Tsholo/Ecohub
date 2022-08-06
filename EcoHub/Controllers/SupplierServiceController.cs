using EcoHub.Models;
using EcoHub.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcoHub.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SupplierServiceController : Controller
    {
        private readonly ISupplierProductService _supplierProduct;
        public SupplierServiceController(ISupplierProductService supplierProductService)
        {
            _supplierProduct = supplierProductService;
        }

        [HttpGet(Name = "GetAllServicesByEmail")]
        public async Task<List<SupplierProduct>> GetAllProductsBySupplier(string email)
        {
            return await _supplierProduct.GetAllProductsBySupplier(email);
        }

        [HttpPost(Name = "AddNewService")]
        public void AddNewProduct(SupplierProduct supplierProduct)
        {
            _supplierProduct.AddNewProduct(supplierProduct);
        }
    }
}
