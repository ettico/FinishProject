using MatchMakings.Core.IRepositories;
using MatchMakings.Core.IServices;
using MatchMakings.Data;
using MatchMakings.Data.Repository;
using MatchMakings.Service;
using MatchMakings.Service.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IFamilyDetailsRepository, FamilyDetailsRepository>();
builder.Services.AddScoped<IFamilyDetailsService, FamilyDetailsService>();

builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();


builder.Services.AddScoped<IMaleRepository, MaleRepository>();
builder.Services.AddScoped<IMaleService, MaleService>();

builder.Services.AddScoped<IMeetingRepository, MeetingRepository>();
builder.Services.AddScoped<IMeetingService, MeetingService>();

builder.Services.AddScoped<IMatchMakerRepository, MatchMakerRepository>();
builder.Services.AddScoped<IMatchMakerService, MatchMakerService>();

builder.Services.AddScoped<IMatchMakingRepository, MatchMakingRepository>();
builder.Services.AddScoped<IMatchMakingService, MatchMakingService>();

builder.Services.AddScoped<IWomenRepository, WomenRepository>();
builder.Services.AddScoped<IWomenService, WomenService>();

builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<JwtService>();

builder.Services.AddAuthorization();

// הוספת מדיניות הרשאות לפי תפקידים
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
    options.AddPolicy("MatchMakerOnly", policy => policy.RequireRole("MatchMaker"));
    options.AddPolicy("CandidateOnly", policy => policy.RequireRole("Women", "Male"));
});


// 🔑 הוספת Authentication & Authorization
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false; // מאפשר גם ב-HTTP
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
        options.Events = new JwtBearerEvents
        {
            OnAuthenticationFailed = context =>
            {
                Console.WriteLine($"❌ Authentication failed: {context.Exception.Message}");
                return Task.CompletedTask;
            },
            OnTokenValidated = context =>
            {
                Console.WriteLine("✅ Token validated successfully!");
                return Task.CompletedTask;
            }
        };
    });
Console.WriteLine("🔑 JWT Key: " + builder.Configuration["Jwt:Key"]);

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
    

});
Console.WriteLine("🔑 JWT Key: " + builder.Configuration["Jwt:Key"]);
Console.WriteLine("🔑 JWT Issuer: " + builder.Configuration["Jwt:Issuer"]);
Console.WriteLine("🔑 JWT Audience: " + builder.Configuration["Jwt:Audience"]);


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
Console.WriteLine("🔑bbb JWT Key: " + builder.Configuration["Jwt:Key"]);
