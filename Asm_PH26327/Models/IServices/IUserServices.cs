<<<<<<< HEAD
﻿using Asm_PH26327.Models;
namespace Asm_PH26327.Models.IServices
=======
﻿namespace Asm_PH26327.Models.IServices
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
{
    public interface IUserServices
    {
        public bool CreateUser(User role);
        public bool UpdateUser(User role);
        public bool DeleteUser(Guid id);
        public List<User> GetAllUser();
        public User GetUserById(Guid id);
        public List<User> GetUserByName(string name);
<<<<<<< HEAD
        public User GetByEmail(string email);
=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
    }
}
