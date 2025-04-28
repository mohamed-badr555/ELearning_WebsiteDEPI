<<<<<<< HEAD
=======
using BLL.Managers.AccountManager;
>>>>>>> origin/register
using DAL.Data.Models;
using DAL.DB_Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
<<<<<<< HEAD
=======
using Microsoft.IdentityModel.Tokens;
>>>>>>> origin/register
using System.Text;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<E_LearningDB>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("EDB"));
});
<<<<<<< HEAD
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
             .AddEntityFrameworkStores<E_LearningDB>();

=======

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
             .AddEntityFrameworkStores<E_LearningDB>()
             .AddDefaultTokenProviders(); ;


builder.Services.AddScoped<IAccountManager, AccountManager>();

builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = "jwt";
    option.DefaultChallengeScheme = "jwt";
}).AddJwtBearer("jwt", option =>
{
    var secretKey = builder.Configuration.GetSection("SecretKey").Value;
    var secretKeyByte = Encoding.UTF8.GetBytes(secretKey);
    SecurityKey securityKey = new SymmetricSecurityKey(secretKeyByte);

    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        IssuerSigningKey = securityKey,
        ValidateIssuer = false,
        ValidateAudience = false,
    };
});
>>>>>>> origin/register

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

<<<<<<< HEAD
app.Run();
=======
app.Run();
>>>>>>> origin/register
