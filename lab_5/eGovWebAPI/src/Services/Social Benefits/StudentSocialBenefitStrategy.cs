using eGovWebAPI.Interfaces;
using eGovWebAPI.Models;

namespace eGovWebAPI.Services.SocialBenefits
{
    public class StudentSocialBenefitStrategy: ISocialBenefitStrategy
    {
        public string BenefitName => "StudentDiscount";
        public bool VerifySocialStatus(Citizen citizen)
        {
            return (!citizen.IsTaxPayer());
        }
        public string GetSocialBenefit(Citizen citizen)
        {
            return $"{citizen.Name} student's social benefit: 50% discount on public transport";
        }

    }
}