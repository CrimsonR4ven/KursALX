using Cyberpunk_RPG_game.Npcs;
using Cyberpunk_RPG_game.Items;

namespace Cyberpunk_RPG_game.Locations.CorpoPlazaLocations
{
    public class RipperCorpoPlaza
    {
        public static void RipperLocation()
        {
            RipperDoc ripperDoc = new RipperDoc(100, "Emanuel", "Welcome Placeholder", "Question 1 Placeholder", "Question 2 Placeholder", CyberneticsList.GetRavenFullBody(), CyberneticsList.GetNovelTechFullBody(), CyberneticsList.GetIECFullBody());
            Console.Write(ripperDoc.RipperShop());
        }
    }
}
