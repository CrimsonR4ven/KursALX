namespace ShootingRangeOnSteroids.ShootingRange.Classes.GunInherited
{
    public class Shotgun : Gun
    {
        public Shotgun(string name, int price)
        {
            Price = price;
            Name = name;
            Type = Enums.GunType.SHOTGUN;
            Lane = Enums.LaneType.LONG;
            // My goals are beyond your understanding
        }
    }
}