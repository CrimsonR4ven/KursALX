using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RPG_game
{
    public class Player
    {
        int HP, MaxHP, Money, StreetRepPoints, StreetRepLvl, NextRepOn;
        string Name;

        public bool IsDead()
        {
            if(HP <= 0)
            {
                return true;
            }
            return false;
        }

    }
}
