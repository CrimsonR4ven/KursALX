using ShootingRangeOnSteroids.ShootingRange.Enums;

namespace ShootingRangeOnSteroids.ShootingRange.Classes
{
    public abstract class Gun
    {
        public double        AmmoGonnaBuy;
        public double        Price;
        public string        Name;
        public bool          CanFullAuto;
        public bool          IsFullAuto;
        public GunType       Type;
        public LaneType      Lane;
        public double FullAutoCost = 1.20; 

        public Gun()
        {
            AmmoGonnaBuy = 0;
            CanFullAuto = false;
            IsFullAuto = false;
        }

        public void Present() 
        {
            Console.WriteLine($" {Name} Price per shot: {Price}");
        }
        public void PresentCheckout()
        {
            double finalPrice = Price * AmmoGonnaBuy;
            if(IsFullAuto)
            {
                finalPrice = finalPrice * FullAutoCost;
            }
            Console.WriteLine($" {Name} Final price: {finalPrice}");
        }
    }
}