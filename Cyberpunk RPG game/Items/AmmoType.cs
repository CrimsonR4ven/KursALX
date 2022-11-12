namespace Cyberpunk_RPG_game.Items
{
    public class AmmoType
    {
        EnumAmmoType ThisAmmoType;
        string Type, Effect;
        int AmountOwned;

        public void BuyAmmo(int amountBuyed)
        {
            AmountOwned = AmountOwned + amountBuyed;
        }
    }
}
