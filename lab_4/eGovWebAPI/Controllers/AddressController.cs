using eGovWebAPI.Models;
using eGovWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGovWebAPI.Controllers
{
    [ApiController]
    [Route("citizen")]

    public class AddressController: ControllerBase
    {
        private readonly CitizenService Citizen;

        public AddressController(CitizenService _citizen)
        {
            Citizen = _citizen;
        }

        [HttpGet ("{name}/address")]
        public IActionResult GetCitizenAddress(string name)
        {
            var citizen = Citizen.GetCitizen(name);
            if (citizen == null || citizen.Address == null)
            {
                return NotFound("Citizen or address was not found");
            }
            return Ok(new 
            {country = citizen.Address.Country,
            city = citizen.Address.City,
            street = citizen.Address.Street});
        }
    }
    
}