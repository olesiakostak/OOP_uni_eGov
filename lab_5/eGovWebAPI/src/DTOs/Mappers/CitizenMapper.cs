using eGovWebAPI.Models;
using eGovWebAPI.DTOs;

namespace eGovWebAPI.DTOs.Mappers
{
    public static class CitizenMapper
    {
        public static CitizenDto ToCitizenDto (this Citizen citizenModel)
        {
            return new CitizenDto
            {
                Name = citizenModel.Name,
                Age = citizenModel.Age,
                TaxPayer = citizenModel.IsTaxPayer(),
                Driver = citizenModel.IsDriver(),
                Address = citizenModel.Address != null ? citizenModel.Address.ToAddressDto() : null
            };
        }
    }
}