using ShootingRangeForms.Objects;

namespace ShootingRangeForms
{
	partial class Form1
	{
        private void ObjectListCreate(List<GunHolder> gunsList)
        {
            GunsPresent.Clear();
            foreach (GunHolder gun in gunsList)
            {
                GunsPresent.Add(new GunPresentBox(gun,gunCart));
            }
        }
        private void ObjectListCreate()
        {
            GunsPresent.Clear();
            foreach (GunHolder gun in gunCart.GunsWillBuy)
            {
                GunsPresent.Add(new GunCartPresentBox(gun, gunCart));
            }
        }
    }
}
