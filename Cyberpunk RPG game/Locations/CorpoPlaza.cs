﻿using Cyberpunk_RPG_game.Items;
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
                RipperDoc ripperDoc = new RipperDoc(100, "Emanuel", "Welcome Placeholder", "Question 1 Placeholder", "Question 2 Placeholder", "answer 1 Placeholder", "answer 2 Placeholder", CyberneticsList.GetRavenFullBody(), CyberneticsList.GetNovelTechFullBody(), CyberneticsList.GetIECFullBody());
                Console.Write(ripperDoc.RipperShop(player));
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
