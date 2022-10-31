using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(player.StreetRepLvl >= 4)
            {
                Console.WriteLine("2. Coś");
            }
            if (player.StreetRepLvl >= 14)
            {
                Console.WriteLine("3. Coś2");
            }
        }

    }
}
