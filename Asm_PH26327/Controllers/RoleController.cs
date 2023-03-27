using Asm_PH26327.Models;
using Asm_PH26327.Models.IServices;
using Asm_PH26327.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Asm_PH26327.Controllers
{
    public class RoleController : Controller
    {
        private readonly ILogger<RoleController> _logger;
        private readonly IRolServices _roleServices;

        public RoleController(ILogger<RoleController> logger)
        {
            _logger = logger;
            _roleServices = new RoleServices();
        }

        public IActionResult Index()
        {
            List<Role> lst = _roleServices.GetRoles();
            return View(lst);
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
   
        public IActionResult Create(Role role)
        {
            if (_roleServices.CreateRole(role))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }

        public IActionResult Detail(Guid id)
        {
            var role = _roleServices.GetRoleById(id);
            return View(role);
        }

        public IActionResult Delete(Guid id)
        {
            if (_roleServices.DeleteROle(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Edit(Role role)
        {
            if (_roleServices.UpdateRole(role))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
