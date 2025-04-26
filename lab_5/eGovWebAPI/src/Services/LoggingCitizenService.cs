using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;

namespace eGovWebAPI.Services
{
    public class LoggingCitizenService: ICitizenService
    {
        private readonly ICitizenService _wrappedCitizen;
        private readonly ILogger<LoggingCitizenService> _logger;

        public LoggingCitizenService(ICitizenService wrappedCitizen, ILogger<LoggingCitizenService> logger)
        {
            _wrappedCitizen = wrappedCitizen;
            _logger = logger;
        }

        public string RegisterCitizen(string name, int age, bool isTaxPayer, bool isDriver, bool hasAddress, string? country = null, string? city = null, string? street = null)
        {
            _logger.LogInformation($"RegisterCitizen is called for {name}");
            var res = _wrappedCitizen.RegisterCitizen(name, age, isTaxPayer, isDriver, hasAddress, country ?? "Unknown", city ?? "Unknown", street ?? "Unknown");
            _logger.LogInformation($"Register result: {name}");
            return res;
        }

        public Citizen? GetCitizen(string name)
        {
            var res = _wrappedCitizen.GetCitizen(name);
            _logger.LogInformation($"Citizen {name} GetCitizen result: {res}");
            return res;
        }

        public string ShowInfo(string name)
        {
            var res = _wrappedCitizen.ShowInfo(name);
            _logger.LogInformation($"Citizen {name} ShowInfo result: {res}");
           return res;
        }
    }
}