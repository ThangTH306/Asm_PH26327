using Asm_PH26327.Models.IServices;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a

namespace Asm_PH26327.Models.Services
{
    public class CartDetailServices : ICartDetailServices
    {
        ShopDbContext context;
        public CartDetailServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateCartDetail(CartDetail cart)
        {
            try
            {
                context.CartDetails.Add(cart);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteDetail(Guid id)
        {
            try
            {
                dynamic user = context.CartDetails.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Users.Remove(user);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public CartDetail GeCartDetailById(Guid id)
        {
            return context.CartDetails.FirstOrDefault(pro => pro.id == id);
        }

        public List<CartDetail> GetAllCartDetail()
        {
            return context.CartDetails.ToList();
        }

<<<<<<< HEAD
        public List<CartDetail> GetCartDetailByName(Guid id)
=======
        public List<CartDetail> GetCartDetailByName(string name)
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public bool UpdateDetail(CartDetail carts, Guid idproduct)
        {
            try
            {

                var ca = context.CartDetails.Find(carts.id);

                ca.Quantity = carts.Quantity;
                ca.IdSp = carts.IdSp;
                ca.UserId = carts.UserId;

=======
        public bool UpdateDetail(CartDetail carts)
        {
            try
            {
                var ca = context.CartDetails.Find(carts.id);
                ca.id = carts.id;
                ca.Quantity = carts.Quantity;
                ca.Product = carts.Product;
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a


                //có thể sửa thêm thuộc tính
                context.CartDetails.Update(ca);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
<<<<<<< HEAD


=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
        }
    }
}
