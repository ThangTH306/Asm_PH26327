using Asm_PH26327.Models.IServices;
using Asm_PH26327.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Asm_PH26327.Controllers
{
    public class CarDetailcontroller : Controller
    {
        private readonly IProductServices productServices;
        private readonly ICartDetailServices cartDetailServices;

        public IActionResult Index()
        {
            return View();
        }
        public CarDetailcontroller()
        {
            productServices = new ProductServices();
            cartDetailServices = new CartDetailServices();
        }
    }
}
