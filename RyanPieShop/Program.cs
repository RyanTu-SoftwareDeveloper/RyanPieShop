using Microsoft.EntityFrameworkCore;
using RyanPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();


builder.Services.AddDbContext<RyanPieShopDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:RyanPieShopDbContextConnection"]);
});

var app = builder.Build();



if(app.Environment.IsDevelopment())
{
   app.UseDeveloperExceptionPage();
}

//add middlewware component
app.UseStaticFiles();
app.UseSession();

//app.MapDefaultControllerRoute(); // "{controller=Home}/{action=Index}/{id?}"

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

DbInitializer.Seed(app);

app.Run();
