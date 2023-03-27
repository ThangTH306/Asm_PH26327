namespace Asm_PH26327.Models
{
    public class Size
    {
        public Guid SizeId { get; set; }
        public string SizeName { get; set; }
        public string MaSize { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        
    }
}
