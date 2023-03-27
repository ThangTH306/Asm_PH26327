namespace Asm_PH26327.Models
{
    public class Color
    {
        public Guid ColorId { get; set; }
        public string Name { get; set; }
        public string Ma { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
