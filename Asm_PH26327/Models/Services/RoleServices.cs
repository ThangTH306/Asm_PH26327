using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{
    public class RoleServices : IRolServices
    {
        ShopDbContext context;
        public RoleServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateRole(Role role)
        {
            try
            {
                context.Roles.Add(role);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteROle(Guid id)
        {
            try
            {
                dynamic role = context.Roles.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Roles.Remove(role);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Role GetRoleById(Guid id)
        {
            return context.Roles.FirstOrDefault(pro => pro.RoleId == id);
        }

        public List<Role> GetRoles()
        {
            return context.Roles.ToList();
        }

        public List<Role> GetRolesByName(string name)
        {
            return context.Roles.Where(pro => pro.RoleName.Contains(name)).ToList();
        }

        public bool UpdateRole(Role role)
        {
            try
            {
                var rol = context.Roles.Find(role.RoleId);
                rol.RoleName = role.RoleName;
                rol.Decreption = role.Decreption;
                rol.Status = role.Status;


                //có thể sửa thêm thuộc tính
                context.Roles.Update(role);
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
