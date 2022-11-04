var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});

var app = builder.Build();

app.UseStaticFiles(); //enable us to use files in wwwroot//
app.UseRouting();
app.UseSession();

app.MapControllerRoute(name: "doctor", pattern: "doctor", defaults: new { controller = "Check", action = "CheckFever" });
app.MapControllerRoute(name: "game", pattern: "game", defaults: new { controller = "Guessing", action = "GuessingGame" });
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=About}/{id?}");

app.Run();




builder.Services.AddDistributedMemoryCache();


