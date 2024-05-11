using System.Text;
using API.Data;
using API.Extensions;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

app.UseHttpsRedirection();//remove later
// Configure the HTTP request pipeline
app.UseCors(builder => builder.AllowAnyHeader().WithOrigins("https://localhost:4200"));
//Authentication midleware must be before 'app.MapControllers();' method and after 'app.UseCors()'.

app.UseAuthentication(); //must be before 'app.UseAuthorization();'
app.UseAuthorization();

app.MapControllers();

app.Run();
