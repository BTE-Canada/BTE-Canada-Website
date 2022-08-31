using BTECanada.Data;
using BTECanada.Models;
using BTECanada.Services;
using BTECanada.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Runtime Compilation
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

// Get Api Settings
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("Api"));

// DB Configuration
var appDataContextConnectionString = builder.Configuration.GetConnectionString("AppDataContext");
builder.Services.AddDbContext<AppDataContext>(options =>
{
    options.UseMySQL(appDataContextConnectionString).EnableDetailedErrors();
});

// Services
builder.Services.AddScoped<IAppDataRepository, AppDataRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
