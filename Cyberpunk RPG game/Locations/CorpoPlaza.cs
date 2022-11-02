using Cyberpunk_RPG_game.Locations.CorpoPlazaLocations;
using Cyberpunk_RPG_game.Npcs;

namespace Cyberpunk_RPG_game.Locations
{
    public class CorpoPlaza
    {
        public static void Location(Player player)
        {
            Console.WriteLine("--------------Corpo Plaza--------------");
            Console.WriteLine(""); // opis lokacji
            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("1. Full Body Conversion Vendor"); // lista  opcji
            if (player.StreetRepLvl >= 4)
            {
                Console.WriteLine("2. Coś");
            }
            if (player.StreetRepLvl >= 14)
            {
                Console.WriteLine("3. Coś2");
            }

            var path = int.Parse(Console.ReadLine());

            if (path == 1)
            {
                RipperCorpoPlaza.RipperLocation();
            }
            else if (path == 2)
            {

            }
            else if (path == 2)
            {

            }
            else if (path == 2)
            {

            }
        }
    }
}
