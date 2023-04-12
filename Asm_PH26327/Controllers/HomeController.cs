using Asm_PH26327.Models;
using Asm_PH26327.Models.IServices;
using Asm_PH26327.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Data;
using System.IO;
<<<<<<< HEAD
using Microsoft.CodeAnalysis;
=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a

namespace Asm_PH26327.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductServices _productServices;
        private readonly IColorSerVices colorSerVices;
        private readonly INsxServices nsxServices;
        private readonly ISizeServices sizeServices;
<<<<<<< HEAD
        private readonly ICartDetailServices cartDetailServices;
        private readonly IUserServices userServices;
        private readonly IRolServices rolServices;
                
=======
       
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _productServices = new ProductServices();
            colorSerVices = new ColorServices();
            nsxServices = new NsxServices();
            sizeServices = new SizeService();
<<<<<<< HEAD
            cartDetailServices = new CartDetailServices();
            userServices = new UserServices();
            rolServices = new RoleServices();
=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
        }

        public IActionResult Index()
        {
            List<Product> products = _productServices.GetAllProducts();
            return View(products);
            //return View();
        }

<<<<<<< HEAD
=======
        public IActionResult GioiThieu()
        {
            return View();
        }
        public IActionResult LienHe()
        {
            return View();
        }
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
        /*--------------------Tạo các sản phẩm-----------------------*/
        public IActionResult Createsp()
        {
            return View();
        }
        public IActionResult CreateCol()
        {
            return View();
        }
        public IActionResult Createsz()
        {
            return View();
        }
        public IActionResult CreatNsx()
        {
            return View();
        }
        public IActionResult CreatUs()
        {
            return View();
        }
<<<<<<< HEAD
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        /*-----------------------Đăng nhập--------------------------------*/

        [HttpPost]

        public IActionResult Register(User user)
        {
            if (userServices.CreateUser(user))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }
        public bool CheckLogin(string email, string password)
        {
            var user = userServices.GetByEmail(email.Trim());
            if (user != null && user.Password == password && user.Status == 1)
            {
                var role = rolServices.GetRoleById(user.RoleId);
                if (role.RoleName != "Staff")
                {
                    return true;
                }
                
            }
            return false;
        }
        [HttpPost]

        public IActionResult Login(string email, string password)
        {
            var isvalid = CheckLogin(email, password);
            if (isvalid)
            {
                var user = userServices.GetByEmail(email.Trim());
                var id = user.UserId.ToString();
                HttpContext.Session.SetString("user_id", id);
                if (user != null)
                {
                    return RedirectToAction("Index");
                    ViewData["ErrorMessage"] = "User not found";
                }
            }
            else
            {
                ViewBag.ErrorMessage = "The user name or password provided is incorrect.";

            }
            return BadRequest();

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user_id");
            return RedirectToAction("Index");
        }

=======
        
        /*-------------------------------------------------------------*/
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a

        /*------------------Sản phẩm--------------*/

        public ActionResult QlSP()
        {
            
                List<Product> products = _productServices.GetAllProducts();
                return View(products);
            
        }
<<<<<<< HEAD

        // Các ảnh không nằm trong thư mục root khi chạy sẽ không hiển thị
        // ra với các phương thức cơ bản => để hiển thị được ta cần phải
        // thực hiện cách sau: Lấy đường dẫn ảnh => copy ảnh đó vào wwwroot
        // sau đó thực hiện hiển thị như bình thường
        [HttpPost]
        public IActionResult Createsp(Product p, IFormFile imageFile)
        {

            if (imageFile != null && imageFile.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "images", imageFile.FileName);
                var stream = new FileStream(path, FileMode.Create);
                imageFile.CopyTo(stream); // Copy ảnh chọn ở form vào wwwroot/images
                // Gán lại giá trị cho thuộc tính Description => Bước 3
                p.Hinhanh = imageFile.FileName; // Bước 4
            }
=======
        [HttpPost]
        public IActionResult Createsp(Product p)
        {
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
            if (_productServices.CreateProduct(p))
            {
                return RedirectToAction("QlSP");
            }
            return BadRequest();
        }
        public IActionResult Detailssp(Guid id)
        {
            var sp = _productServices.GetProductById(id);
            return View(sp);
        }
        public IActionResult Deletesp(Guid id)
        {
            if (_productServices.DeleteProduct(id))
            {
                return RedirectToAction("QLSP");
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult Editsp(Guid id)
        {
            var product = _productServices.GetProductById(id);
<<<<<<< HEAD
            var products = SessionServices.GetObjectFromSession(HttpContext.Session, "History");
            var existingProduct = products.FirstOrDefault(p => p.id == id);
            if (products.Count == 0)
            {
                products.Add(product);
                SessionServices.SetObjectToSession(HttpContext.Session, "History", products);
            }
            else
            {
                if (SessionServices.CheckObjectInList(id, products))
                {
                    if (existingProduct != null)
                    {
                        return View(product);
                    }
                    else
                    {
                        products.Remove(existingProduct);
                    }
                }
                else
                {
                    products.Add(product);
                    SessionServices.SetObjectToSession(HttpContext.Session, "History", products);
                }
            }

            return View(product);
        }
        public IActionResult Editsp(Product p, IFormFile imageFile)
=======
            return View(product);
        }
        public IActionResult Editsp(Product p)
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
        {
            var Products = _productServices.GetProductById(p.id);
            if (p.Price < 1)
            {
                ModelState.AddModelError("", "Giá phải lớn hơn 1");
                return View();
            }
            if (p.availabelQuantity < 5)
            {
                ModelState.AddModelError("", "Số Lượng phải lớn hơn 5");
                return View();
            }
            if (p.status < 1)
            {
                ModelState.AddModelError("", "Số Lượng phải lớn hơn 1");
                return View();
            }
<<<<<<< HEAD
            if (imageFile != null && imageFile.Length > 0) // Không null không rỗng
            {
                // Thực hiện trỏ tới thư mục root để lát thực hiện việc copy
                var path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot", "images", imageFile.FileName); // Bước 2
                // Kết quả: aaa/wwwroot/images/xxx.jpg, Path.Combine = tổng hợp đường dẫn
                var stream = new FileStream(path, FileMode.Create);
                // Vì chúng ta thực hiện việc copy => Tạo mới => Create
                imageFile.CopyTo(stream); // Copy ảnh chọn ở form vào wwwroot/images
                // Gán lại giá trị cho thuộc tính Description => Bước 3
                p.Hinhanh = imageFile.FileName; // Bước 4
            }
=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
            if (_productServices.UpdateProduct(p))
            {
                return RedirectToAction("QLSP");
            }
            else return BadRequest();
        }
        /*-------------------------------------------------------------*/

        /*------------------Color--------------*/



        [HttpPost]
        public IActionResult CreateCol(Color coler)
        {
            if (colorSerVices.CreateColor(coler))
            {
                return RedirectToAction("Colors");
            }
            return BadRequest();
        }

        public ActionResult Colors()
        {
            List<Color> color = colorSerVices.GetAllColor();
            return View(color);
        }

        public IActionResult Deletems(Guid id)
        {
            if (colorSerVices.DeleteColor(id))
            {
                return RedirectToAction("Colors");
            }
            return BadRequest();
        }

        public IActionResult Detailsms(Guid id)
        {
            var cl = colorSerVices.GetColorById(id);
            return View(cl);
        }


        [HttpGet]
        public IActionResult Editms(Guid id)
        {
            var co = colorSerVices.GetColorById(id);
            return View(co);
        }
        public IActionResult Editms(Color cl)
        {
            if (colorSerVices.UpdateColor(cl))
            {
                return RedirectToAction("Colors");
            }
            return BadRequest();
        }

        /*---------------------------------------------------------------------*/

        /*------------------Size--------------*/

        [HttpPost]
        public IActionResult Createsz(Size sz)
        {
            if (sizeServices.CreateSize(sz))
            {
                return RedirectToAction("Sizes");
            }
            return BadRequest();
        }

        public ActionResult Sizes()
        {
            List<Size> sz = sizeServices.GetSizes();
            return View(sz);
        }
        public IActionResult Deletesz(Guid id)
        {
            if (sizeServices.DeleteSize(id))
            {
                return RedirectToAction("Sizes");
            }
            return BadRequest();
        }

        public IActionResult Detailsz(Guid id)
        {
            var sz = sizeServices.GetSizeById(id);
            return View(sz);
        }

        [HttpGet]
        public IActionResult Editsz(Guid id)
        {
            var co = sizeServices.GetSizeById(id);
            return View(co);
        }
        public IActionResult Editsz(Size size)
        {
            if (sizeServices.UpdateSize(size))
            {
                return RedirectToAction("Sizes");
            }
            return BadRequest();
        }
        /*---------------------------------------------------------------------*/


        /*------------------NSX--------------*/

        public ActionResult Nsxes()
        {
            List<Nsx> nsx = nsxServices.GetAllNsxs();
            return View(nsx);
        }

        [HttpPost]
        public IActionResult CreatNsx(Nsx n)
        {
            if (nsxServices.CreateNsx(n))
            {
                return RedirectToAction("Nsxes");
            }
            else return BadRequest();
        }

        public IActionResult DetailsN(Guid id)
        {
            var n = nsxServices.GetNsxById(id);
            return View(n);
        }

        public IActionResult DeleteN(Guid id)
        {
            if (nsxServices.DeleteNsx(id))
            {
                return RedirectToAction("Nsxes");
            }
            else return BadRequest();
        }

        [HttpGet]

        public IActionResult EditN(Guid id)
        {
            var co = nsxServices.GetNsxById(id);
            return View(co);
        }
        public IActionResult EditN(Nsx x)
        {
            if (nsxServices.UpdateNsx(x))
            {
                return RedirectToAction("Nsxes");
            }
            return BadRequest();
        }
<<<<<<< HEAD
        /*-------------------------------Session--------------------------------*/

        [HttpPost]
        public IActionResult CallBack(Guid id, string action)
        {
            if (action == "CallBack")
            {
                var obj = SessionServices.GetObjectFromSession(HttpContext.Session, "History").FirstOrDefault(p => p.id == id);
                if (_productServices.UpdateProduct(obj))
                {
                    return RedirectToAction("QLSP");
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                var product = _productServices.GetProductById(id);
                return RedirectToAction("UpdateProduct", product);
            }
        }

        public IActionResult ShowOld()
        {
            var products = SessionServices.GetObjectFromSession(HttpContext.Session, "History");
            return View(products);
        }
        /*--------------------------Giỏ hàng--------------------------------------*/

        public  IActionResult AddtoCart(Guid id)
        {

            var product = _productServices.GetProductById(id);

            var cartdetails = SessionCart.GetObjectFromSession(HttpContext.Session, "Cart");
            var newcartdetail = new CartDetail
            {
                IdSp = product.id,
                Quantity = 1,
                Product = product,
            };

            if (cartdetails.Count == 0)
            {
                cartdetails.Add(newcartdetail);
                SessionCart.SetObjectToSession(HttpContext.Session, "Cart", cartdetails);
            }
            else
            {
                if (SessionCart.CheckObjectInList(id, cartdetails))
                {
                    foreach (var p in cartdetails)
                    {
                        if (p.IdSp == id)
                        {
                            p.Quantity++;
                            break;
                        }
                    }
                    SessionCart.SetObjectToSession(HttpContext.Session, "Cart", cartdetails);
                    //return Content("Bình thường chúng ta sẽ thêm số lượng nhưng vì " +
                    //    "lười nên không thêm mà chỉ đưa ra thông báo vô ích này");
                }
                else
                {
                    cartdetails.Add(newcartdetail);
                    SessionCart.SetObjectToSession(HttpContext.Session, "Cart", cartdetails);
                }
            }
            return RedirectToAction("ShowCart");



        }

        public IActionResult RemoveCart(Guid id ,int quantity)
        {
            var product = _productServices.GetProductById(id);


            var cartdetails = SessionCart.GetObjectFromSession(HttpContext.Session, "Cart");
            var newcartDetails = new CartDetail
            {

                IdSp = product.id,
                Quantity = quantity,
                Product = product,

            };
            if (cartdetails.Count == 0) // Trong trường hợp mà list rỗng
            {

                return Content("không có sp xóa vào mắt");

            }
            else
            {

                cartdetails.Remove(newcartDetails);
                SessionCart.SetObjectToSession(HttpContext.Session, "Cart", cartdetails);

            }

            return RedirectToRoute("ShowCart");


        }
        public IActionResult ShowCart()
        {
            var product = SessionCart.GetObjectFromSession(HttpContext.Session, "Cart");
            return View(product);
        }
=======
        /*---------------------------------------------------------------------*/

        /*---------------------------------------------------------------------*/

        /*---------------------------------------------------------------------*/

>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}