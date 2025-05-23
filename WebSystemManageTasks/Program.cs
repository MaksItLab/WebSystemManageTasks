using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.Extensions.Options;
using WebSystemManageTasks.Extensions;
using WebSystemManageTasks.Interfaces.Providers;
using WebSystemManageTasks.Interfaces.Services;
using WebSystemManageTasks.Providers.JwtToken;
using WebSystemManageTasks.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));

services.AddScoped<IAuthService, AuthService>();
services.AddScoped<IPasswordHasherService, PasswordHasherService>();
services.AddScoped<IJwtProvider, JwtProvider>();

services.AddControllers();

services.AddSwaggerGen();

services.AddJwtAuthentication(services.BuildServiceProvider().GetRequiredService<IOptions<JwtOptions>>());

services.AddAuthorization();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    HttpOnly = HttpOnlyPolicy.Always,
    Secure = CookieSecurePolicy.Always
});

app.Map("/", () => Results.Redirect("/swagger/index.html"));

app.Run();
