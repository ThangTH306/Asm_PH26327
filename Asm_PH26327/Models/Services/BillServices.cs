using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{
    public class BillServices : IBillServices
    {
        ShopDbContext context;
        public BillServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateBill(Bill bi)
        {
            try
            {
                context.Bills.Add(bi);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteBill(Guid id)
        {
            try
            {
                dynamic bi = context.Bills.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.Bills.Remove(bi);

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Bill> GetBill()
        {
            return context.Bills.ToList();
        }

        public Bill GetBill(Guid id)
        {
            return context.Bills.FirstOrDefault(pro => pro.Id == id);
        }

        public List<Bill> GetBill(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBill(Bill bil)
        {
            try
            {
                var Bills = context.Bills.Find(bil.Id);
                Bills.CreateTime = bil.CreateTime;
                Bills.Status = bil.Status;
                //có thể sửa thêm thuộc tính
                context.Bills.Update(Bills);
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
