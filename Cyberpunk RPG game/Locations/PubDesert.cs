using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cyberpunk_RPG_game.Locations
{
    public class PubDesert
    {
        public static string PubWelcome()
        {
            Console.WriteLine("-Small pub Next to the highway in the middle of nowhere-");
            //some dialogues
            Console.WriteLine("");
            Console.WriteLine("Bartender: Well, I'm eager to hear your story Wanderer, but firstly, what's your name?");
            Console.Write("My name is ");
            var name = Console.ReadLine();
            Console.WriteLine(name);
            return name;
        }
    }
}
