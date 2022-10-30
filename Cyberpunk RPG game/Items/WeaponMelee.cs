namespace Cyberpunk_RPG_game.Items
{
    public class WeaponMelee
    {
        public string Model, Make, Rarity;
        public int Damage, SellPrice, BuyPrice;

        public WeaponMelee()
        {
            Make = "None";
            Rarity = "None";
            Model = "Hands";
            Damage = 5;
        }
        public WeaponMelee(string model, string make, string rarity, int damage, int sellPrice, int buyPrice)
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
