using System.Data;

namespace Asm_PH26327.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }
        public virtual ICollection<BilDetail> BilDetails { get; set; }
        public virtual User User { get; set; }
    }
}
