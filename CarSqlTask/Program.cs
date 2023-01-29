using CarSqlTask.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=LAPTOP-NQ3V92F6;Database=FirstDb;Trusted_Connection=true;");
});
var app = builder.Build();

app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
app.Run();
