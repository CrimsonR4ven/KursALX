namespace Cyberpunk_RPG_game.Items
{
    public class Granade
    {
        public int Dmg, NumberOfItems, SellPrice, BuyPrice;
        public string ItemName;
        //here change to Enemy enemy after creating
        public void ThrowGranade(Player player)
        {
            //enemy.DealDmg(Dmg)
            player.HPGain(1);
            NumberOfItems--; 
        }
    }
}
