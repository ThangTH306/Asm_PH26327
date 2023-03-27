using Asm_PH26327.Models;
namespace Asm_PH26327.Models.IServices
{
    public interface IUserServices
    {
        public bool CreateUser(User role);
        public bool UpdateUser(User role);
        public bool DeleteUser(Guid id);
        public List<User> GetAllUser();
        public User GetUserById(Guid id);
        public List<User> GetUserByName(string name);
        public User GetByEmail(string email);
    }
}
