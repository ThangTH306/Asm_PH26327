namespace Asm_PH26327.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
        public virtual Role Role { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
