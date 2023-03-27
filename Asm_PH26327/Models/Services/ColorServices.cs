using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{
    public class ColorServices : IColorSerVices
    {
        ShopDbContext context;
        public ColorServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateColor(Color color)
        {
            try
            {
                context.Colors.Add(color);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteColor(Guid id)
        {
            try
            {
                dynamic color = context.Colors.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Colors.Remove(color);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Color> GetAllColor()
        {
            return context.Colors.ToList();

        }

        public Color GetColorById(Guid id)
        {
            return context.Colors.FirstOrDefault(pro => pro.ColorId == id);
        }

        public List<Color> GetColorByName(string name)
        {
            return context.Colors.Where(pro => pro.Name.Contains(name)).ToList();
        }

        public bool UpdateColor(Color color)
        {
            try
            {
                var co = context.Colors.Find(color.ColorId);
                co.Name = color.Name;
                co.Status = color.Status;
                co.Ma  = co.Ma;
               

                //có thể sửa thêm thuộc tính
                context.Colors.Update(co);
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
