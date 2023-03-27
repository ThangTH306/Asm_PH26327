

using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Asm_PH26327.Models
{
    public class Product
    {
       
        public Guid id { get; set; }
        public string Name { get; set; }
        public Guid SizeId { get; set; }
        public Guid NsxId { get; set; }
        public Guid ColorId { get; set; }
        public string Color { get; set; }
        public string Nsx { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int availabelQuantity { get; set; }
        public int status { get; set; }
        public string Supplier { get; set; }
        public string Descreption { get; set; }
     
        public string Hinhanh { get; set; }

        public virtual ICollection<BilDetail> BilDetail { get; set; }
        public virtual ICollection<CartDetail> CartDetail { get; set; }
    }
}
