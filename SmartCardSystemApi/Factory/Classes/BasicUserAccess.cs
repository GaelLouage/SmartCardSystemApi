using SmartCardSystemApi.Factory.Interfaces;

namespace SmartCardSystemApi.Factory.Classes
{
    public class BasicUserAccess :  ICardAccess
    {
        public string Operation()
        {
            return "Basic read access";
        }
    }
}
