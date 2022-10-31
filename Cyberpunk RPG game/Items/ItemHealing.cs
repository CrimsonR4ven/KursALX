using System.Reflection.Metadata;

namespace Cyberpunk_RPG_game.Items
{
    public class ItemHealing
    {
        public int HealingEffect, NumberOfItems, SellPrice, BuyPrice;
        public string ItemName;

        public void UseItem(Player player)
        {
            player.HPGain(HealingEffect);
            NumberOfItems--; 
        }
    }
}
