using Microsoft.AspNetCore.Components.Web;

namespace Asm_PH26327.Models.IServices
{
    public interface IRolServices
    {
        public bool CreateRole(Role role);
        public bool UpdateRole(Role role);
        public bool DeleteROle(Guid id);
        public List<Role> GetRoles();
        public Role GetRoleById(Guid id);

        public List<Role> GetRolesByName(string name);
    }
}
