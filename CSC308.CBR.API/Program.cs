using Business.Location;
using Business.Match;
using Business.Ranking;
using CSC308.CBR.Data.Match;
using CSC308.CBR.DataObjects;
using Data.Location;
using Data.Match;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connStr = builder.Configuration.GetConnectionString("MySQL");
var serverVersion = ServerVersion.AutoDetect(connStr);

builder.Services.AddDbContext<CBRContext>(o => o.UseMySql(
        connStr,
        serverVersion
    // options => options.EnableRetryOnFailure(
    //     maxRetryCount:5,
    //     maxRetryDelay: System.TimeSpan.FromSeconds(30),
    //     errorNumbersToAdd: null
    //     )
        )
);

// repositories
builder.Services.AddSingleton<ILocationRepository, LocationRepository>();
builder.Services.AddSingleton<IRankingRepository, RankingRepository>();
builder.Services.AddSingleton<IMatchRepository, MatchRepository>();

// data objects
builder.Services.AddSingleton<ILocationDataObject, LocationDataObject>();
builder.Services.AddSingleton<IMatchDataObject, MatchDataObject>();

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