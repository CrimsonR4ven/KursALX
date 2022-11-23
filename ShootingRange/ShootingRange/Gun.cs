using 
namespace ShootingRange.ShootingRange
{
    public abstract class Gun
    {
        public int AmmoGonnaBuy;
        public double Price;
        public string Name;

        public Gun(string name, int price)
        {
            Price = price;
            Name = name;
            AmmoGonnaBuy = 0;
        }
    }
}
