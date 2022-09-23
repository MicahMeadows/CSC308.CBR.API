using Business.Location;
using Business.Match;
using Business.Ranking;
using Data.Location;
using Data.Match;
using DataObjects;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var connStr = builder.Configuration.GetConnectionString("MySQL");
var serverVersion = ServerVersion.AutoDetect(connStr);

builder.Services.AddDbContext<CBRContext>(o => o.UseMySql(connStr, serverVersion));

// repositories
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<IRankingRepository, RankingRepository>();
builder.Services.AddScoped<IMatchRepository, MatchRepository>();

// data objects
builder.Services.AddScoped<ILocationDataObject, SqlLocationDataObject>();
builder.Services.AddScoped<IMatchDataObject, SqlMatchDataObject>();

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