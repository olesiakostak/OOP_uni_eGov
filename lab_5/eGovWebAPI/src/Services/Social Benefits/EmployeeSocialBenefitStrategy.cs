using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;

namespace eGovWebAPI.Services.SocialBenefits
{
    public class EmployeeSocialBenefitStrategy: ISocialBenefitStrategy
    {
        public string BenefitName => "EmployeeDiscount";
        public bool VerifySocialStatus(Citizen citizen)
        {
            return (citizen.Age >= 18 && citizen.IsTaxPayer());
        }
        public string GetSocialBenefit(Citizen citizen)
        {
            return $"{citizen.Name} employee's social benefit: medical subsidy, ensurance";    
        }
    }
}