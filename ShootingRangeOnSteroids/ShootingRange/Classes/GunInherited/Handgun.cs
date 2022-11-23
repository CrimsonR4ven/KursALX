namespace ShootingRangeOnSteroids.ShootingRange.Classes.GunInherited
{
    public class Handgun : Gun
    {
        public Handgun(string name, int price)
        {
            Price = price;
            Name = name;
            Type = Enums.GunType.HANDGUN;
            Lane = Enums.LaneType.SHORT;
        }
    }
}
