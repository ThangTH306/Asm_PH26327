using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Asm_PH26327.Configutions
{
    public class CartDetailConfigution : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(p => p.id);
            builder.HasOne(p => p.Cart).WithMany(p => p.CartDetail).
                HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Product).WithMany(p => p.CartDetail).
                HasForeignKey(p => p.IdSp);
        }
    }
}
