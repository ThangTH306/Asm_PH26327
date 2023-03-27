namespace Asm_PH26327.Models
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public string Decreption { get; set; }
        public virtual ICollection<CartDetail> CartDetail { get; set; }
        public virtual User User { get; set; }
    }
}
