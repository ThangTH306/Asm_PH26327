using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{

    public class CartServices : ICartServices
    {
        ShopDbContext context;
        public CartServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateCart(Cart cart)
        {
            try
            {
                context.Carts.Add(cart);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteCart(Guid id)
        {
            try
            {
                dynamic cart = context.Carts.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Users.Remove(cart);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

<<<<<<< HEAD
        public List<Cart> GetCart(string name)
        {
            //return context.Carts.Where(pro => pro.Decreption.Contains(name)).ToList();
            throw new NotImplementedException();

        }

        public List<Cart> GetAllCart()
=======
        public List<Cart> get(string name)
        {
            return context.Carts.Where(pro => pro.Decreption.Contains(name)).ToList();
        }

        public List<Cart> GetAllRoles()
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
        {
            return context.Carts.ToList();

        }

<<<<<<< HEAD
        public Cart GetGetAllCartById(Guid id)
=======
        public Cart GetRoleById(Guid id)
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
        {
            return context.Carts.FirstOrDefault(pro => pro.UserId == id);
        }

        public bool UpdateCart(Cart cart)
        {
            try
            {
                var ca = context.Carts.Find(cart.UserId);
                ca.User = cart.User;
                ca.Decreption = cart.Decreption;
               


                //có thể sửa thêm thuộc tính
                context.Carts.Update(ca);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
