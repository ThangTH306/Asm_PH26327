namespace Asm_PH26327.Models.IServices
{
    public interface IBillServices
    {
        public bool CreateBill(Bill Color);
        public bool UpdateBill(Bill role);
        public bool DeleteBill(Guid id);
        public List<Bill> GetBill();
        public Bill GetBill(Guid id);

        public List<Bill> GetBill(string name);
    }
}
