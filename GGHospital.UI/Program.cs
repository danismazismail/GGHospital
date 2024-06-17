using GGHospital.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GGHospitalContext>(opt => opt.UseSqlServer("server=DESKTOP-NVBA98H\\SQLEXPRESS;Database=GGHospitalDB;Trusted_connection=true;TrustServerCertificate=true;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Deneme}/{action=Index}/{id?}");

app.Run();