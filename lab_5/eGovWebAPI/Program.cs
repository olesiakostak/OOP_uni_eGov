using Microsoft.Extensions.DependencyInjection;
using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;
using eGovWebAPI.Services;
using eGovWebAPI.Factories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ITaxPayer, TaxPayer>();
builder.Services.AddScoped<IDriver, Driver>();
builder.Services.AddScoped<IAddressFactory, AddressFactory>();
builder.Services.AddScoped<CitizenService>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<ICitizenService>(provider =>
    new LoggingCitizenService(
        provider.GetRequiredService<CitizenService>(),
        provider.GetRequiredService<ILogger<LoggingCitizenService>>()
    )
);

var app = builder.Build();

app.MapControllers();
app.Run();
