using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{
    public class UserServices : IUserServices
    {
        ShopDbContext context;
        public UserServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateUser(User user)
        {
            try
            {
                context.Users.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteUser(Guid id)
        {
            try
            {
                dynamic user = context.Users.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Users.Remove(user);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<User> GetAllUser()
        {
            return context.Users.ToList();
        }

        public User GetUserById(Guid id)
        {
            return context.Users.FirstOrDefault(pro => pro.UserId == id);
        }

        public List<User> GetUserByName(string name)
        {
            return context.Users.Where(pro => pro.Username.Contains(name)).ToList();
        }

        public bool UpdateUser(User pro)
        {
            try
            {
                var user = context.Users.Find(pro.UserId);
                user.Username = pro.Username;
                user.Password = pro.Password;
                user.Status = pro.Status;


                //có thể sửa thêm thuộc tính
                context.Users.Update(user);
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
