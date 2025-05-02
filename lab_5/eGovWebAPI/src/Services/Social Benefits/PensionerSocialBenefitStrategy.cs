using eGovWebAPI.Models;
using eGovWebAPI.Interfaces;

namespace eGovWebAPI.Services.SocialBenefits
{
    public class PensionerSocialBenefitStrategy: ISocialBenefitStrategy
    {
        public string BenefitName => "PensionSupport";
        public bool VerifySocialStatus(Citizen citizen)
        {
            return (citizen.Age >= 60);
        }
        public string GetSocialBenefit(Citizen citizen)
        {
            return $"{citizen.Name} pensionier's social benefit: free transport, subbsidy";
        }
    }
}