using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{
    public class SizeService : ISizeServices
    {
        ShopDbContext context;
        public SizeService()
        {
            context = new ShopDbContext();
        }

        public bool CreateSize(Size sz)
        {
            try
            {
                context.Sizes.Add(sz);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteSize(Guid id)
        {
            try
            {
                dynamic sz = context.Sizes.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Sizes.Remove(sz);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Size GetSizeById(Guid id)
        {
            return context.Sizes.FirstOrDefault(pro => pro.SizeId == id);
        }

        public List<Size> GetSizeByName(string name)
        {
            return context.Sizes.Where(pro => pro.SizeName.Contains(name)).ToList();
        }

        public List<Size> GetSizes()
        {
            return context.Sizes.ToList();
        }

        public bool UpdateSize(Size sz)
        {
            try
            {
                var co = context.Sizes.Find(sz.SizeId);
                co.SizeName = sz.SizeName;
                co.MaSize = sz.MaSize;
                co.Status = sz.Status;
                //có thể sửa thêm thuộc tính
                context.Sizes.Update(co);
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
