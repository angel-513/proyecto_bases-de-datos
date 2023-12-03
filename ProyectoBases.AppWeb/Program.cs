using Microsoft.EntityFrameworkCore;
using ProyectoBases.BLL.Service;
using ProyectoBases.BLL.Service.Impl;
using ProyectoBases.DAL.DataContext;
using ProyectoBases.DAL.Repositories;
using ProyectoBases.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<bd_ferreteriaContext>(opciones =>
{
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<IGenericRepository<Direccion>, DireccionRepository>();
builder.Services.AddScoped<IDireccionService, DireccionService>();

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
