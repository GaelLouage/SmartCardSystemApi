namespace SmartCardSystemApi.Enums
{
    public enum SmartCardAccessLevel
    {
        USER,              // Basic read access
        AUTHENTICATED_USER, // Requires PIN authentication
        ADMINISTRATOR,      // Requires cryptographic authentication
        ISSUER         // Full control by the card issuer
    }
}
