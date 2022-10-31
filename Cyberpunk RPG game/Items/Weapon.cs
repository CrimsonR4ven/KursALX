using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RPG_game.Items
{
    public class Weapon
    {
        public string Model, Make, Rarity;
        public int Damage, SellPrice, BuyPrice;

        public Weapon() 
        {
            Make = "None";
            Rarity = "None";
            Model = "None";
            Damage = 0;
        }
        public Weapon(string model, string make, string rarity, int damage, int sellPrice, int buyPrice)
        {
            Make = make;
            Rarity = rarity;
            Model = model;
            Damage = damage;
            SellPrice = sellPrice;
            BuyPrice = buyPrice;
        }
    }
}
