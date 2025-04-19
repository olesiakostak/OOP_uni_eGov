using Microsoft.Extensions.DependencyInjection;
using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;
using eGovWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ITaxPayer, TaxPayer>();
builder.Services.AddScoped<IDriver, Driver>();
builder.Services.AddScoped<IAddress, Address>();
builder.Services.AddScoped<CitizenService>();

var app = builder.Build();

app.MapControllers();
app.Run();
