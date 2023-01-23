using ShootingRangeData.ShootingRangeDB;

namespace ShootingRangeForms.Objects
{
	public class BundleHolder
	{	
		public string Name;
		public double Price;
		public string Description;
		public List<GunHolder> gunsInBundle;

		public BundleHolder(Bundle bundle)
		{
			Name		 = bundle.Name;
			Price		 = bundle.Price;
			Description  = bundle.Description;
			gunsInBundle = GunHolder.FromGunList(bundle.Guns);
		}
	}
}
