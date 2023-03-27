using Asm_PH26327.Models.IServices;

namespace Asm_PH26327.Models.Services
{
    public class BillDetailServices : IBillDetailServices
    {
        ShopDbContext context;
        public BillDetailServices()
        {
            context = new ShopDbContext();
        }
        public bool CreateBillDetail(BilDetail bd)
        {
            try
            {
                context.BilDetails.Add(bd);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteBillDetail(Guid id)
        {
            try
            {
                dynamic bd = context.BilDetails.Find(id);//find chỉ dùng được khi id là khoá chính,dynamic là kiểu dữ liệu- var là từ khoá
                context.BilDetails.Remove(bd);
                
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public BilDetail GetBilDetailById(Guid id)
        {
            return context.BilDetails.FirstOrDefault(bd => bd.id == id);

        }

        public List<BilDetail> GetBilDetailByName(string name)
        {
            throw new NotImplementedException();

        }

        public List<BilDetail> GetBilDetails()
        {
            return context.BilDetails.ToList();
        }

        public bool UpdateBillDetail(BilDetail bid)
        {
            try
            {
                var bd = context.BilDetails.Find(bid.id);
                bd.Price = bid.Price;
                bd.Quantity = bid.Quantity;
                //có thể sửa thêm thuộc tính
                context.BilDetails.Update(bd);
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
