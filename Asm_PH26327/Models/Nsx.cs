﻿namespace Asm_PH26327.Models
{
    public class Nsx
    {
        public Guid NsxId { get; set; }
        public string Name { get; set; }
        public string Ma { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
