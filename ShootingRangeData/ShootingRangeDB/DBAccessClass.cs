namespace ShootingRangeData.ShootingRangeDB
{
	public class DBAccessClass
	{
		ShootingRangeContext db;
		public DBAccessClass()
		{ 
			db = new ShootingRangeContext();
		}
		public bool TestConnection()
		{
			try
			{
				var funny = db.Guns.Where(g => g.Category.Name == "funny").ToList();
			}
			catch
			{
				return false;
			}
			return true;
		}
		public List<Gun> GetGunListFromCategory(string category, string connString)
		{
			return db.Guns.Where(g => g.Category.Name == category).OrderBy(g => g.Name).ToList();
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
			return db.Lanes.ToList();
		}
		public List<GunLane> GetLaneListFromType(string type,string connString)
		{
			return db.Lanes.Where(l => l.Lane.Name == type).ToList();
		}
	}
}
