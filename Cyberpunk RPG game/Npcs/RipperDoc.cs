using Cyberpunk_RPG_game.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RPG_game.Npcs
{
    public class RipperDoc
    {
        int Money;
        string Name, WelcomeText;
        Cybernetic Cyber, Cyber2, Cyber3;

        public void RipperShop()
        {
            Console.WriteLine(WelcomeText);
            Console.WriteLine("");
            Console.WriteLine(WelcomeText);
        }
    }
}
