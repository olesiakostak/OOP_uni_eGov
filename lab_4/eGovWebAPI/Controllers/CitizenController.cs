using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace eGovWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CitizenController : ControllerBase
{
    private readonly ITaxPayer TaxPayer;
    private readonly IDriver Driver;
    private readonly IAddress Address;

    public CitizenController(ITaxPayer _tax_payer, IDriver _driver, IAddress _address)
    {
        TaxPayer = _tax_payer;
        Driver = _driver;
        Address = _address;
    }

    [HttpPost("register")]
    public IActionResult RegisterCitizen ([FromQuery] string name, [FromQuery] int age)
    {
        var citizen = new Citizen(name, age, TaxPayer, Driver, Address);
        return Ok($"Citizen {name} registered with age {age}.");
    }

    // [HttpPost ("taxpayer")]
    // public IActionResult 

    [HttpGet]
    public IActionResult getCitizen()
    {
        return Ok("Citizen inf processed");
    }
}