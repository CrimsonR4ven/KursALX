namespace ShootingRangeOnSteroids.ShootingRange.Classes.GunInherited
{
    public class Machinegun : Gun
    {
        public Machinegun(string name, int price)
        {
            Price = price;
            Name = name;
            Type = Enums.GunType.MACHINEGUN;
            Lane = Enums.LaneType.MEDIUM;
            CanFullAuto = true;
        }
    }
}