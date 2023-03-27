using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Asm_PH26327.Configutions
{
    public class NsxConfigution : IEntityTypeConfiguration<Nsx>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Nsx> builder)
        {
            builder.HasKey(x => x.NsxId);
            builder.Property(x => x.Name).HasColumnType("varchar(256)");
            builder.Property(x => x.Ma).HasColumnType("varchar(256)");
            builder.Property(x => x.Status).HasColumnType("varchar(256)");
        }
    }
}
