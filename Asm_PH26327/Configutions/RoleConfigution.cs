using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_PH26327.Configutions
{
    public class RoleConfigution : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(p => p.RoleId);
            builder.Property(p => p.RoleName).HasColumnType("varchar(100)");
            builder.Property(p => p.Decreption).HasColumnType("nvarchar(1000)");
        }
    }
}
