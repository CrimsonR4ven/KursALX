namespace ShootingRangeOnSteroids.ShootingRange.Classes.GunInherited
{
    public class  SniperRifle: Gun
    {
        public SniperRifle(string name, int price)
        {
            Price = price;
            Name = name;
            Type = Enums.GunType.SNIPERRIFLE;
            Lane = Enums.LaneType.LONG;
        }
    }
}