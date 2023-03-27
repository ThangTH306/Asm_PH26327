using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_PH26327.Configutions
{
    public class SizeConfigution : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasKey(x => x.SizeId);
            builder.Property(x => x.SizeName).HasColumnType("varchar(256)");
            builder.Property(x => x.MaSize).HasColumnType("varchar(256)");
            builder.Property(x => x.Status).HasColumnType("varchar(256)");

        }   
    }
}
