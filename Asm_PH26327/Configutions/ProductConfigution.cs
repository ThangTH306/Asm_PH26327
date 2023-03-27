using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Asm_PH26327.Configutions
{
    public class ProductConfigution : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Supplier).IsUnicode(true).
                IsFixedLength().HasMaxLength(100);// nvarchar(100)
        }
    }
}
