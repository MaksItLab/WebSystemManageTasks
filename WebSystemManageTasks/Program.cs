using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebSystemManageTasks.Extensions;
using WebSystemManageTasks.Infrastructure.DatabaseContext;
using WebSystemManageTasks.Interfaces.Providers;
using WebSystemManageTasks.Interfaces.Repositories;
using WebSystemManageTasks.Interfaces.Services;
using WebSystemManageTasks.Providers.JwtToken;
using WebSystemManageTasks.Repositories;
using WebSystemManageTasks.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));

services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<ITaskRepository, TaskRepository>();
services.AddScoped<IAuthService, AuthService>();
services.AddScoped<IPasswordHasherService, PasswordHasherService>();
services.AddScoped<IJwtProvider, JwtProvider>();

services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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
