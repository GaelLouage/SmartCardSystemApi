using SmartCardSystemApi.Factory.Interfaces;

namespace SmartCardSystemApi.Factory.Classes
{
    public class IsSuerAccess :  ICardAccess
    {
        public string Operation()
        {
            return "Full control by the card issuer";
        }
    }
}
