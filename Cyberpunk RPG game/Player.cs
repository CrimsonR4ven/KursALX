using Cyberpunk_RPG_game.Items;

namespace Cyberpunk_RPG_game
{
    public class Player
    {
        // used for likeliness of special encounters
        public int Luck;
        public int HP, MaxHP, Money, StreetRepPoints, StreetRepLvl, StreetRepNextLvl;
        public int Netrunning, Mechanics, Charisma, Strength, Reflex;
        public int SkillPointsUsed, SkillPointsAvailable;
        public string Name;

        public WeaponMelee Melee; 
        public Weapon Weapon1, Weapon2;
        public Cybernetic BodyCyber, OpticsCyber, SkinCyber, ArmsCyber;

        public Player(string name)
        {
            HP = 100;
            MaxHP = 100;
            Money = 1000;
            StreetRepPoints = 0;
            StreetRepLvl = 1;
            StreetRepNextLvl = 500;
            SkillPointsUsed = 0;
            SkillPointsAvailable = 0;
            Name = name;
            Melee = new WeaponMelee();
            Weapon1 = new Weapon();
            Weapon2 = new Weapon();
        }

        public void ShowMenuStats()
        { 
            Console.WriteLine($"---------------------------------------{Name}---------------------------------------");
            Console.WriteLine($"| HP: {HP}/{MaxHP} | StreetRep: Lvl {StreetRepLvl} | Next level on: {StreetRepPoints}/{StreetRepNextLvl} | EuroDolars: {Money} |");
            Console.WriteLine($"Weapon 1: {Weapon1.Model}\n");
            Console.WriteLine($"Weapon 2: {Weapon2.Model} {Weapon2.Make} {Weapon2.Rarity} {Weapon2.Damage} {Weapon2.SellPrice} {Weapon2.BuyPrice}\n");
            Console.WriteLine($"Weapon 3 (melee): {Melee.Model}, {Melee.Damage} Dmg");
        }

        public void AddRepPoints(int repPoints)
        {
            StreetRepPoints = StreetRepPoints + repPoints;
            if(StreetRepPoints >= StreetRepNextLvl)
            {
                StreetRepLvl++;
                SkillPointsAvailable++;
                StreetRepNextLvl = StreetRepNextLvl + 500;
            }
        }

        public void NewLevelPoints()
        {
              //przyznanie punktu umiejętności
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
