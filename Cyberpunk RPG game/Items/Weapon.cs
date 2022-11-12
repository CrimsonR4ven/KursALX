namespace Cyberpunk_RPG_game.Items
{
    public class Weapon
    {
        public string Model, Make, Rarity;
        public int Damage, SellPrice, BuyPrice;
        EnumAmmoType AmmoType;

        public Weapon() 
        {
            Make = "None";
            Rarity = "None";
            Model = "None";
            Damage = 0;
        }
        public Weapon(string model, string make, string rarity, int damage, int sellPrice, int buyPrice, EnumAmmoType ammoType)
        {
            Make = make;
            Rarity = rarity;
            Model = model;
            Damage = damage;
            SellPrice = sellPrice;
            BuyPrice = buyPrice;
            AmmoType = ammoType;
        }
    }
}
