using eGovWebAPI.Models;

namespace eGovWebAPI.Interfaces
{
    public interface IAddress
    {
        public void InputAddress();
        public void ShowAddress();
        public Address? GetAddress();
    }
}