namespace Asm_PH26327.Models.IServices
{
    public interface IBillDetailServices
    {
        public bool CreateBillDetail(BilDetail bd);
        public bool UpdateBillDetail(BilDetail bd);
        public bool DeleteBillDetail(Guid id);
        public List<BilDetail> GetBilDetails();
        public BilDetail GetBilDetailById(Guid id);

        public List<BilDetail> GetBilDetailByName(string name);
    }
}
