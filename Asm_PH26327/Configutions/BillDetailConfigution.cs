using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Asm_PH26327.Configutions
{
    public class BillDetailConfigution : IEntityTypeConfiguration<BilDetail>
    {
        public void Configure(EntityTypeBuilder<BilDetail> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(p => p.Quantity).IsRequired().
                HasColumnType("int");
            // set khoá ngoại
            builder.HasOne(p => p.Bill).WithMany(p => p.BilDetails).
                HasForeignKey(p => p.idHd).HasConstraintName("FK_HD");
            builder.HasOne(p => p.Product).WithMany(p => p.BilDetail).
               HasForeignKey(p => p.idSp).HasConstraintName("FK_SP");
        }
    }
}
