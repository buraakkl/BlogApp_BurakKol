using BlogApp.Business.Abstract;
using BlogApp.Business.Concrete;
using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var sqliteConnection = builder.Configuration.GetConnectionString("SqliteCon");
builder.Services.AddDbContext<MyAppContext>(options => options.UseSqlite(sqliteConnection));

builder.Services.AddScoped<IBlogService, BlogManager>();

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IBlogRepository, BlogRepository>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();







// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
