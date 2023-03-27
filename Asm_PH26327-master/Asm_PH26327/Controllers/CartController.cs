using Asm_PH26327.Models;
using Asm_PH26327.Models.IServices;
using Asm_PH26327.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Asm_PH26327.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartServices cartServices;

        public CartController()
        {
            cartServices = new CartServices();
        }

        public ActionResult ShowCart()
        {
            List<Cart> carts = cartServices.GetAllCart();
            return View(carts);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
