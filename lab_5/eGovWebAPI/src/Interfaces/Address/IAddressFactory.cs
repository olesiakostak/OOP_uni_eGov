namespace eGovWebAPI.Interfaces
{
    public interface IAddressFactory
    {
        IAddress Create(string _country, string _city, string _street);
    }
}