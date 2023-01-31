namespace ShootingRangeData.ShootingRangeDB
{
	public class DBAccessClass
	{
		public List<Gun> GetGunListFromCategory(string category, string connString)
		{
			using (ShootingRangeContext db = new ShootingRangeContext())
			{
				return db.Guns.Where(g => g.Category.Name.ToLower() == category.ToLower()).ToList();
			}
		}
		public List<Bundle> GetBundleList(string connString)
		{
			using (ShootingRangeContext db = new ShootingRangeContext(connString))
			{
				return db.Bundles.ToList();
			}
		}
		public List<GunLane> GetLaneList(string connString)
		{
			using (ShootingRangeContext db = new ShootingRangeContext(connString))
			{
				return db.Lanes.ToList();
			}
		}
	}
}
