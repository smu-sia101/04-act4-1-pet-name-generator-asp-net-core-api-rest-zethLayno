namespace PetNameGenerator.API.Constants
{
    public class Names
    {
        private static readonly Dictionary<string, List<string>> PetNames = new()
        {
            { "dog", new List<string> { "KOA", "CHICHI", "LUNA", "WOLFHOUND", "PIPOY" } },
            { "cat", new List<string> { "PUSSY", "KURSING", "MUSANG", "KITTY", "PETCHAY" } },
            { "bird", new List<string> { "BIRDYLOG", "TUKA", "BILLIT", "RAVEN", "QUIN" } }
        };
    }
}
