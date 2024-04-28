using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//dependency injesion
builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

//Di
var app = builder.Build();

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt6QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRbQllhTn9Td0VjUHtadnY=");

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
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");//default page to be opened

app.Run();
