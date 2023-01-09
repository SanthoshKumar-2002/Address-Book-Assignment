using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApi.Contracts;
using WebApi2.Repository;
using WebApi2.Contracts;
using WebApi2.Entities;
using WebApi2.LoginCheck;
using WebApi2.Security;
using System;
using WebApi2Test;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.ConfigureLogging(logging =>
    {
        logging.AddConsole();
    });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ILoginCheck, LoginCheck>();
builder.Services.AddScoped<IGenerate, Generate>();
builder.Services.AddDbContext<ApiDbContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<Context>
(o => o.UseInMemoryDatabase("MyDatabase"));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer =
        builder.Configuration["jwt:Issuer"],
        ValidAudience = builder.Configuration["jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["jwt:key"]))
    };
});
Log.Logger = new LoggerConfiguration()
.WriteTo.File("C:\\Users\\91900\\OneDrive\\Documents\\logger\\as1.log", rollingInterval: RollingInterval.Day)
.CreateLogger();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();