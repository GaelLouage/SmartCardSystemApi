using SmartCardSystemApi.Factory.Interfaces;

namespace SmartCardSystemApi.Factory.Classes
{
    public class AdministratorAccess :  ICardAccess
    {
        public string Operation()
        {
            return "Requires cryptographic authentication";
        }
    }
}
