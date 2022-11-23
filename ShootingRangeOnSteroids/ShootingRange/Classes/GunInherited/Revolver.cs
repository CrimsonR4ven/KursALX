namespace ShootingRangeOnSteroids.ShootingRange.Classes.GunInherited
{
    public class Revolver: Gun
    {
        public Revolver(string name, int price)
        {
            Price = price;
            Name = name;
            Type = Enums.GunType.REVOLVER;
            Lane = Enums.LaneType.SHORT;
        }
    }
}
