using MatchMakings.Core.IRepositories;
using MatchMakings.Core.IServices;
using MatchMakings.Data;
using MatchMakings.Data.Repository;
using MatchMakings.Service;
using Microsoft.Extensions.DependencyInjection;

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

builder.Services.AddDbContext<DataContext>();

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

app.Run();
