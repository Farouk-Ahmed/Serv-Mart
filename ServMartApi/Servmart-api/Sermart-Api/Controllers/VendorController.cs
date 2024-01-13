using Application_Layer.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Sermart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Vendor")]
    public class VendorController : ControllerBase
    {
        private readonly VendorSoldProductsRepo _vspr;
        public VendorController(VendorSoldProductsRepo vspr)
        {
            _vspr = vspr;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var reasult = await _vspr.GetMySoldProducts(id);
            return Ok(reasult);
        }
    }
}
