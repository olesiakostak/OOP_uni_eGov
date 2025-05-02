using eGovWebAPI.Models;

namespace eGovWebAPI.Interfaces
{
    public interface ISocialBenefitStrategy
    {
        string BenefitName {get; }
        bool VerifySocialStatus(Citizen citizen);
        string GetSocialBenefit(Citizen citizen);
    }
}