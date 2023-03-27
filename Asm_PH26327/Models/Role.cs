namespace Asm_PH26327.Models
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string Decreption { get; set; }
        public int Status { get; set; }
        public virtual ICollection<BilDetail> BilDetail { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
