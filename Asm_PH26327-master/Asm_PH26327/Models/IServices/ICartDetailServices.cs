namespace Asm_PH26327.Models.IServices
{
    public interface ICartDetailServices
    {
        public bool CreateCartDetail(CartDetail role);
        public bool UpdateDetail(CartDetail role);
        public bool DeleteDetail(Guid id);
        public List<CartDetail> GetAllCartDetail();
        public CartDetail GeCartDetailById(Guid id);
        public List<CartDetail> GetCartDetailByName(string name);
    }
}
