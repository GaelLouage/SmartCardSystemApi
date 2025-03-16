using SmartCardSystemApi.Factory.Interfaces;

namespace SmartCardSystemApi.Factory.Classes
{
    public class AutheticatedUserAccess :  ICardAccess
    {
        public string Operation()
        {
            return "Requires PIN authentication";
        }
    }
}
