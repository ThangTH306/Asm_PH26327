namespace Asm_PH26327.Models.IServices
{
    public interface ICartServices
    {
        public bool CreateCart(Cart role);
        public bool UpdateCart(Cart role);
        public bool DeleteCart(Guid id);
<<<<<<< HEAD
        public List<Cart> GetAllCart();
        public Cart GetGetAllCartById(Guid id);
        public List<Cart> GetCart(string name);
=======
        public List<Cart> GetAllRoles();
        public Cart GetRoleById(Guid id);
        public List<Cart> get(string name);
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
    }
}
