using SmartCardSystemApi.Enums;
using SmartCardSystemApi.Factory.Interfaces;

namespace SmartCardSystemApi.Factory.Classes
{
    public  class SmartCardFactory
    {
        public static ICardAccess GetSmartCard(SmartCardAccessLevel lvl)
        {
            return lvl switch
            {
                SmartCardAccessLevel.AUTHENTICATED_USER => new AutheticatedUserAccess(),
                SmartCardAccessLevel.ADMINISTRATOR => new AdministratorAccess(),
                SmartCardAccessLevel.ISSUER => new IsSuerAccess(),
                _ => new BasicUserAccess()
            };
        }
    }
}
