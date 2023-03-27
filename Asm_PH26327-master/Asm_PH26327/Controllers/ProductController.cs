using Asm_PH26327.Models.IServices;
using Asm_PH26327.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Asm_PH26327.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        public ProductController()
        {
            _productServices = new ProductServices();

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
