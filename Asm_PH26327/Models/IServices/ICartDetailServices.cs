namespace Asm_PH26327.Models.IServices
{
    public interface ICartDetailServices
    {
<<<<<<< HEAD
        public bool CreateCartDetail(CartDetail cartd);
        public bool UpdateDetail(CartDetail cart, Guid idproduct);
        public bool DeleteDetail(Guid idproduct);
        public List<CartDetail> GetAllCartDetail();
        public CartDetail GeCartDetailById(Guid id);
        public List<CartDetail> GetCartDetailByName(Guid id);
=======
        public bool CreateCartDetail(CartDetail role);
        public bool UpdateDetail(CartDetail role);
        public bool DeleteDetail(Guid id);
        public List<CartDetail> GetAllCartDetail();
        public CartDetail GeCartDetailById(Guid id);
        public List<CartDetail> GetCartDetailByName(string name);
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
    }
}
