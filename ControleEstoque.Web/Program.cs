using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Adicione autentica��o baseada em cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Conta/Login"; // Caminho para a p�gina de login
        options.LogoutPath = "/Conta/Logout"; // Caminho para logout
    });

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseAuthentication(); // Adicione este middleware
app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
