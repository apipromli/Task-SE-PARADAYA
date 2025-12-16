using PresensiSiswa.Services;

var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

// Dependency Injection
builder.Services.AddSingleton<IAttendanceService, AttendanceService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Attendance}/{action=Index}/{id?}");

app.Run();
