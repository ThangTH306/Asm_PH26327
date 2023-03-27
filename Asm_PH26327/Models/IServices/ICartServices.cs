namespace Asm_PH26327.Models.IServices
{
    public interface ICartServices
    {
        public bool CreateCart(Cart role);
        public bool UpdateCart(Cart role);
        public bool DeleteCart(Guid id);
        public List<Cart> GetAllRoles();
        public Cart GetRoleById(Guid id);
        public List<Cart> get(string name);
    }
}
