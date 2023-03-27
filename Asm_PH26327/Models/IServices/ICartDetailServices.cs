namespace Asm_PH26327.Models.IServices
{
    public interface ICartDetailServices
    {
        public bool CreateCartDetail(CartDetail cartd);
        public bool UpdateDetail(CartDetail cart, Guid idproduct);
        public bool DeleteDetail(Guid idproduct);
        public List<CartDetail> GetAllCartDetail();
        public CartDetail GeCartDetailById(Guid id);
        public List<CartDetail> GetCartDetailByName(Guid id);
    }
}
