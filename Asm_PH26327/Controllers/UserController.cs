using Asm_PH26327.Models.IServices;
using Asm_PH26327.Models.Services;
using Asm_PH26327.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asm_PH26327.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserServices _userServices;
        private readonly IRolServices _roleServices;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            _userServices = new UserServices();
            _roleServices = new RoleServices();
        }

        public ActionResult Show()
        {
            List<User> lst = _userServices.GetAllUser();

            return View(lst);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User p)
        {
            if (_userServices.CreateUser(p))
            {
                return RedirectToAction("Show");
            }
            else
            {
                return BadRequest();
            }
        }

        public IActionResult Details(Guid id)
        {
            var obj = _userServices.GetUserById(id);
            return View(obj);
        }

        public IActionResult Delete(Guid id)
        {
            if (_userServices.DeleteUser(id))
            {
                return RedirectToAction("Show");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var obj = _userServices.GetUserById(id);
            return View(obj);
        }

        public IActionResult Edit(User p)
        {
            if (_userServices.UpdateUser(p))
            {
                return RedirectToAction("Show");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
