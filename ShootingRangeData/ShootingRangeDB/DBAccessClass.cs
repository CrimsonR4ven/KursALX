namespace ShootingRangeData.ShootingRangeDB
{
	public class DBAccessClass
	{
		public List<Gun> GetGunListFromCategory(string category)
		{
			using (ShootingRangeContext db = new ShootingRangeContext("a"))
			{
				return db.Guns.Where(g => g.Category.Name.ToLower() == category.ToLower()).ToList();
			}
		}
	}
}
