<<<<<<< HEAD
﻿using Asm_PH26327.Models.IServices;
using Asm_PH26327.Models.Services;

=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
<<<<<<< HEAD
builder.Services.AddTransient<IProductServices, ProductServices>();
/*
    AddSingleTon: Tao ra 1 doi tuong service ton tai cho den khi vong doi cua ung dung ket thuc. Service nay se duoc dung chung cho cac request. Loai dang ki nay phu hop voi cac service mang tinh toan cuc va khong thay doi
    AddScoped: Moi request cu the se tao ra 1 doi tuong service, doi tuong nay duoc giu nguyen trong qua trinh su ly request phu hop cho cac service ma phuc vu cho 1 loai request cu the
    AddTransient: Moi request se nhan 1 service cu the khi co yeu cau. Moi service se duoc tao moi tai thoi diem co yeu cau. Phu hop cho cac service co nhieu trang thai, nhieu yeu cau http va mang tinh linh dong hon
 */

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(2);
});//them cai nay de su dung duoc session voi timeout = 10 giay
=======
>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
<<<<<<< HEAD
app.UseSession();//them cai nay de su dung duoc session

app.UseRouting();
//app.UseStatusCodePagesWithReExecute("/Home/Index");
//// Midddleware tự động redirect người dùng đến /Home/Index khi gặp bất kì lỗi nào HTTP status code
=======

app.UseRouting();

>>>>>>> a80c7644f75ede78d6f33356cfae309531897b0a
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
