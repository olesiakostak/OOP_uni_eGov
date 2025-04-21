using eGovWebAPI.Models;
using eGovWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGovWebAPI.Controllers
{
    [ApiController]
    [Route("citizen")]

    public class AddressController: ControllerBase
    {
        private readonly CitizenService Citizens;
        private readonly AddressService AddressService;

        public AddressController(CitizenService _citizens, AddressService _addressService)
        {
            Citizens = _citizens;
            AddressService = _addressService;
        }

        // [HttpGet ("{name}/address")]
        // public IActionResult GetCitizenAddress(string name)
        // {
        //     var citizen = Citizens.GetCitizen(name);
        //     if (citizen == null || citizen.Address == null)
        //     {
        //         return NotFound("Citizen or address was not found");
        //     }
        //     return Ok(new 
        //     {country = citizen.Address.Country,
        //     city = citizen.Address.City,
        //     street = citizen.Address.Street});
        // }

        [HttpGet ("{name}/address")]
        public IActionResult GetCitizenAddress(string name)
        {
            return Ok(AddressService.GetAddress(name));
        }

        [HttpPost ("{name}/changeAddress")]
        public IActionResult ChangeCitizenAddress(string name, string country, string city, string street)
        {
            return Ok(AddressService.ChangeAddress(name, country, city, street));
        }
    }
    
}