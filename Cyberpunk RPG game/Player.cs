using Cyberpunk_RPG_game.Items;
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
        WeaponMelee Melee;
        Weapon Weapon1, Weapon2;

        public Player(string name)
        {
            HP = 100;
            MaxHP = 100;
            Money = 1000;
            StreetRepPoints = 0;
            StreetRepLvl = 1;
            NextRepOn = 500;
            Name = name;
            Melee = new WeaponMelee();
            Weapon1 = new Weapon();
            Weapon2 = new Weapon();
        }

        public void ShowStats()
        { 
            //nie ma jeszcze
            Console.WriteLine($"---------------------------------------{Name}---------------------------------------");
            Console.WriteLine($"| HP: {HP}/{MaxHP} | StreetRep: Lvl {StreetRepLvl} | Next level on: {StreetRepPoints}/{NextRepOn} | EuroDolars: {Money} |");
            Console.WriteLine($"Weapon 1: {Weapon1.Model}\n");
            Console.WriteLine($"Weapon 2: {Weapon2.Model} {Weapon2.Make} {Weapon2.Rarity} {Weapon2.Damage} {Weapon2.SellPrice} {Weapon2.BuyPrice}\n");
            Console.WriteLine($"Weapon 3 (melee): {Melee.Model}, {Melee.Damage} Dmg");
        }

        public bool IsDead()
        {
            if(HP <= 0)
            {
                return true;
            }
            return false;
        }

        public void HPLoss(int x)
        {
            HP = HP - x;
        }

        public void TestNewWeapon()
        {
            Weapon2 = new Weapon("Katana", "Arasaka", "Legendary", 10, 100, 150);
        }
    }
}
