using ASP_NET_HW_Module_02_part_01.Models;
using ASP_NET_HW_Module_02_part_01.Models.Figures;
using ASP_NET_HW_Module_02_part_01.Repositories;
using ASP_NET_HW_Module_02_part_01.Repositories.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IRepositoryAnimals, RepositoryAnimals>();

builder.Services.AddTransient<IRepositoryFigures, RepositoryFigures>();
builder.Services.AddTransient<Figure, Circle>();
builder.Services.AddTransient<Figure, Square>();
builder.Services.AddTransient<Figure, Triangle>();

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

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tasks}/{action=Index}/{id?}");

app.Run();
