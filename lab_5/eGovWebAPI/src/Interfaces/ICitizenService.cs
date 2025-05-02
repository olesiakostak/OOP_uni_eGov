using eGovWebAPI.Models;

namespace eGovWebAPI.Interfaces
{
    public interface ICitizenService
    {
        public string RegisterCitizen(string name, 
                                      int age, 
                                      bool isTaxPayer, 
                                      bool isDriver, 
                                      bool hasAddress,
                                      string country, 
                                      string city, 
                                      string street);

        public Citizen? GetCitizen(string name);
        public string ShowInfo(string name);
        string GetCitizenSocialBenefit(Citizen citizen, string BenefitName);
    }
}