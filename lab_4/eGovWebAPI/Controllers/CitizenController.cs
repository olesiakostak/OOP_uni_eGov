using eGovWebAPI.Services;
using eGovWebAPI.DTOs.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace eGovWebAPI.Controllers
{
    [ApiController]
    [Route("citizen")]
    public class CitizenController : ControllerBase
    {
        private readonly CitizenService _citizenService;

        public CitizenController(CitizenService citizenService)
        {
            _citizenService = citizenService;
        }

        [HttpPost("register")]
        public IActionResult RegisterCitizen(string name, int age, bool isTaxPayer, bool isDriver, bool hasAddress, string? country = null,
                string? city = null, string? street = null)
        {
            var message = _citizenService.RegisterCitizen(name, age, isTaxPayer, isDriver, hasAddress, country, city, street);
            return Ok(message);
        }

        [HttpGet("{name}")]
        public IActionResult ShowCitizenInfo(string name)
        {
            var citizen = _citizenService.GetCitizen(name);
            if (citizen == null)
            {
                return NotFound("Citizen was not found");
            }
            return Ok(citizen.ToCitizenDto());
        }

        [HttpGet]
        public IActionResult GetCitizen()
        {
            return Ok("Citizen inf processed");
        }
    }
}