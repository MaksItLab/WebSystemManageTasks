using Microsoft.AspNetCore.Builder;
using System;
using WebSystemManageTasks.Interfaces.Services;
using WebSystemManageTasks.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddScoped<IAuthService, AuthService>();
services.AddScoped<IPasswordHasherService, PasswordHasherService>();
services.AddScoped<IJwtProviderService, JwtProviderService>();

services.AddControllers();
services.AddSwaggerGen();

services.AddAuthentication("Bearer")
    .AddJwtBearer();

var app = builder.Build();

app.UseAuthentication();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Map("/", () => Results.Redirect("/swagger/index.html"));

app.Run();
