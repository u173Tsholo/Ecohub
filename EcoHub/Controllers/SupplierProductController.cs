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

        [HttpGet(Name = "GetAllProductsBySupplier")]
        public async Task GetAllProductsBySupplier(SupplierProduct supplierProduct)
        {
            await _supplierProduct.GetAllProductsBySupplier(supplierProduct);
        }

        [HttpPost(Name = "AddNewProduct")]
        public void AddNewProduct(SupplierProduct supplierProduct)
        {
            _supplierProduct.AddNewProduct(supplierProduct);
        }

    }
}
