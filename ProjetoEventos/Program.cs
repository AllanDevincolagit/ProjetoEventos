using Microsoft.EntityFrameworkCore;
using ProjetoEventos;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>(a => a.UseSqlServer("Server=DESKTOP-GDT3KDH\\SQLEXPRESS;Database=ProjetoEventos;User Id=sa;Password=1234;"));
builder.Services.AddAuthentication("CookieAuthentication").AddCookie("CookieAuthentication", option =>
{
    option.LoginPath = "/Login/Entrar";
    option.AccessDeniedPath = "/Login/Negado";
});

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
