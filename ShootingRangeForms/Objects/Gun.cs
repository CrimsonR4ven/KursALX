using ShootingRangeForms.Enums;
using ShootingRangeData.ShootingRangeDB;
namespace ShootingRangeForms.Objects
{
    public class GunHolder
    {
        public int    Amount;
        public double Price;
        public string Name;
        public string ImgName;
        public string Description;

        public LaneEnum     Lane;
        public CategoryEnum Category;

        public GunHolder(Gun gun)
        {
            Amount = 0;
            Name = gun.Name;
            Price = gun.Price;
            ImgName = gun.ImgName;
            Description = gun.Description;
            Lane = OperationsOnEnum.GetLaneEnum(gun.Lane);
            Category = OperationsOnEnum.GetCategory(gun.Category);
        }
        public GunHolder(string name, string description, string imgName, double price)
        {
            Name        = name;
            Description = description;
            ImgName     = imgName;
            Price       = price;
            Amount      = 0; 
        }

        public static List<GunHolder> FromGunList(List<Gun> gunList)
		{
            List<GunHolder> list = new List<GunHolder>();
            foreach(Gun gun in gunList)
			{
                list.Add(new GunHolder(gun));
			}
            return list;
		}
    }
}
