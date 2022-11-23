namespace ShootingRangeOnSteroids.ShootingRange.Classes.GunInherited
{
    public class Rifle : Gun
    {
        public Rifle(string name, int price)
        {
            Price = price;
            Name = name;
            Type = Enums.GunType.RIFLE;
            Lane = Enums.LaneType.MEDIUM;
            CanFullAuto = true;
        }
    }
}