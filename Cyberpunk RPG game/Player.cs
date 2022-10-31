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
        // used for likeliness of special encounters
        int Luck;
        public int HP, MaxHP, Money, StreetRepPoints, StreetRepLvl, NextRepOn;
        int Netrunning, Mechanics, Charisma, Strength, Reflex;
        string Name;
        WeaponMelee Melee;
        Weapon Weapon1, Weapon2;
        Cybernetic BodyCyber, OpticsCyber, SkinCyber, ArmsCyber;

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

        public void ShowMenuStats()
        { 
            Console.WriteLine($"---------------------------------------{Name}---------------------------------------");
            Console.WriteLine($"| HP: {HP}/{MaxHP} | StreetRep: Lvl {StreetRepLvl} | Next level on: {StreetRepPoints}/{NextRepOn} | EuroDolars: {Money} |");
            Console.WriteLine($"Weapon 1: {Weapon1.Model}\n");
            Console.WriteLine($"Weapon 2: {Weapon2.Model} {Weapon2.Make} {Weapon2.Rarity} {Weapon2.Damage} {Weapon2.SellPrice} {Weapon2.BuyPrice}\n");
            Console.WriteLine($"Weapon 3 (melee): {Melee.Model}, {Melee.Damage} Dmg");
        }

        public void AddRepPoints()
        {
            //self explainatory
        }

        public void NewLevel()
        {
              //sekwencja nowego poziomu, +punkty reputacji? na pewno + punkt umiejętności/skilla
        }

        public bool IsDead()
        {
            if(HP <= 0)
            {
                return true;
            }
            return false;
        }

        public void HPLoss(int loss)
        {
            HP = HP - loss;
        }
        public void HPGain(int gain)
        {
            HP = HP + gain;
        }
        public void EquipBuyedCyber(Cybernetic cyber)
        {
            Netrunning = Netrunning + cyber.StatBoostNet;
            Strength = Strength + cyber.StatBoostStr;
            Charisma = Charisma + cyber.StatBoostChr;
            Reflex = Reflex + cyber.StatBoostRef;

            if (cyber.CyberType == EnumCybernetics.FULLBODY)
            {
                BodyCyber = cyber;
            }
            else if (cyber.CyberType == EnumCybernetics.SKIN)
            {
                SkinCyber = cyber;
            }
            else if (cyber.CyberType == EnumCybernetics.OPTICS)
            {
                OpticsCyber = cyber;
            }
            else if (cyber.CyberType == EnumCybernetics.MELEEWEP)
            {
                ArmsCyber = cyber;
            }
        }

        public void TestNewWeapon()
        {
            Weapon2 = new Weapon("Katana", "Arasaka", "Legendary", 10, 100, 150);
        }
    }
}
