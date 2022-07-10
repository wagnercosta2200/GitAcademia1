using GerenciamentoContato.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicione servi�os ao cont�iner.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
    (opcions => opcions.UseSqlServer
    (" Data Source = DESKTOP - K02VTBG\\SQLEXPRESS; Server = DESKTOP-K02VTBG\\SQLEXPRESS; Database = GerenciamentoContato_db; Trusted_Connection = True; "));


var app = builder.Build();

// Configure  solicita��o HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    //O valor HSTS padr�o � 30 dias. Voc� pode querer mudar isso para cen�rios de produ��o, veja https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
