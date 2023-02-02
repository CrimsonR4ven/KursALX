using ShootingRangeForms.Enums;
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
                GunsPresent.Add(new GunPresentBox(gun, gunCart, this));
            }
        }
        private void ObjectListCreate(List<LaneHolder> laneList)
        {
            GunsPresent.Clear();
            foreach (LaneHolder lane in laneList)
            {
                GunsPresent.Add(new LanePresentBox(lane, gunCart, this));
            }
        }
        private void ObjectListCreate()
        {
            GunsPresent.Clear();
            foreach (GunHolder gun in gunCart.GunsWillRent)
            {
                GunsPresent.Add(new GunCartPresentBox(gun, gunCart, this));
            }
            foreach (LaneHolder lane in gunCart.LanesWillRent)
            {
                GunsPresent.Add(new GunCartPresentBox(lane, gunCart, this));
            }
            if (GunsPresent.Count == 0)
			{
                GunsPresent.Add(new GunCartPresentBox());
            }
        }
        private void ObjectListCreate(Dictionary<LaneEnum, bool> dict)
        {
            GunsPresent.Clear();
            foreach (var (key, value) in gunCart.Lanes)
            {
                if (value == true)
                {
                    var listLanes = LaneHolder.FromLaneList(dBAccess.GetLaneListFromType(OperationsOnEnum.GetLaneType(key),"idk"));
                    GunsPresent.Add(new LaneChoicePresentBox(listLanes[0], listLanes[1], gunCart, this));
                }
            }
        }
    }
}
