using eGovWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGovWebAPI.Controllers
{
    [ApiController]
    [Route("citizen")]
    public class CitizenController : ControllerBase
    {
        private readonly CitizenService Citizen;

        public CitizenController(CitizenService _citizen)
        {
            Citizen = _citizen;
        }

        [HttpPost("register")]
        public IActionResult RegisterCitizen (string name, int age, bool isTaxPayer, bool isDriver, bool hasAddress, string? country = null,
                string? city = null, string? street = null)
        {
            var message = Citizen.RegisterCitizen(name, age, isTaxPayer, isDriver, hasAddress, country, city, street);
            return Ok(message);
        }

        [HttpGet ("{name}")]
        public IActionResult ShowCitizenInfo(string name)
        {
            var info = Citizen.ShowInfo(name);
            return Ok(info);
        }

        // [HttpPost ("taxpayer")]
        // public IActionResult 

        [HttpGet]
        public IActionResult getCitizen()
        {
            return Ok("Citizen inf processed");
        }
    }
}