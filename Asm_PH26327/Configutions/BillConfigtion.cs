using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Asm_PH26327.Configutions
{
    public class BillConfigtion : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Hoadon"); // Đặt tên bảng
            builder.HasKey(p => new { p.Id }); //Thiết lập khoá chính
            //Thiết lập cho các thuộc tính
            builder.Property(p => p.Status).HasColumnType("int").
                IsRequired();// int not null
            builder.HasOne(p => p.User).WithMany(p => p.Bill).HasForeignKey(p => p.UserId);
        }
    }
}
