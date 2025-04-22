using eGovWebAPI.DTOs;
using eGovWebAPI.Interfaces;

namespace eGovWebAPI.DTOs.Mappers
{
    public static class AddressMapper
    {
        public static AddressDto ToAddressDto(this IAddress addressModel)
        {
            return new AddressDto
            {
                Country = addressModel.Country,
                City = addressModel.City,
                Street = addressModel.Street
            };
        }
    }

}
