using eGovWebAPI.Models;
using eGovWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGovWebAPI.Controllers
{
    [ApiController]
    [Route("citizen")]
    public class AddressController : ControllerBase
    {
        private readonly CitizenService _citizens;
        private readonly AddressService _addressService;

        public AddressController(CitizenService citizens, AddressService addressService)
        {
            _citizens = citizens;
            _addressService = addressService;
        }

        [HttpGet("{name}/address")]
        public IActionResult GetCitizenAddress(string name)
        {
            return Ok(_addressService.GetAddress(name));
        }

        [HttpPost("{name}/changeAddress")]
        public IActionResult ChangeCitizenAddress(string name, string country, string city, string street)
        {
            return Ok(_addressService.ChangeAddress(name, country, city, street));
        }
    }
}