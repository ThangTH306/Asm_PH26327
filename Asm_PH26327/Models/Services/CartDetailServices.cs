using Asm_PH26327.Models.IServices;
using Microsoft.EntityFrameworkCore;

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

        public List<CartDetail> GetCartDetailByName(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDetail(CartDetail carts, Guid idproduct)
        {
            try
            {

                var ca = context.CartDetails.Find(carts.id);

                ca.Quantity = carts.Quantity;
                ca.IdSp = carts.IdSp;
                ca.UserId = carts.UserId;



                //có thể sửa thêm thuộc tính
                context.CartDetails.Update(ca);
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
