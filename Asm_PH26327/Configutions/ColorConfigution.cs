using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_PH26327.Configutions
{
    public class ColorConfigution : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(x => x.ColorId);
            builder.Property(x => x.Name).HasColumnType("varchar(256)");
            builder.Property(x => x.Ma).HasColumnType("varchar(256)");
            builder.Property(x => x.Status).HasColumnType("varchar(256)");
        }
    }
}
