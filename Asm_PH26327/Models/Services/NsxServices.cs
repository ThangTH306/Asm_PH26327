using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{
    public class NsxServices : INsxServices
    {
        ShopDbContext context;
        public NsxServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateNsx(Nsx nsx)
        {
            try
            {
                context.Nsxes.Add(nsx);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteNsx(Guid id)
        {
            try
            {
                dynamic nsx = context.Nsxes.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Nsxes.Remove(nsx);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Nsx> GetAllNsxs()
        {
            return context.Nsxes.ToList();

        }

        public Nsx GetNsxById(Guid id)
        {
            return context.Nsxes.FirstOrDefault(pro => pro.NsxId == id);
        }

        public List<Nsx> GetNsxByName(string name)
        {
            return context.Nsxes.Where(pro => pro.Name.Contains(name)).ToList();
        }

        public bool UpdateNsx(Nsx nsx)
        {
            try
            {
                var nx = context.Nsxes.Find(nsx.NsxId);
                nx.Name = nsx.Name;
                nx.Status = nsx.Status;
                nx.Ma = nsx.Ma;
                
                //có thể sửa thêm thuộc tính
                context.Nsxes.Update(nx);
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
