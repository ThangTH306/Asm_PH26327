namespace Asm_PH26327.Models
{
    public class BilDetail
    {
        public Guid id { get; set; }
        public Guid idSp { get; set; }
        public Guid idHd { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
