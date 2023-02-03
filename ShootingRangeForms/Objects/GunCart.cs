using ShootingRangeForms.Enums;

namespace ShootingRangeForms.Objects
{
    public class Cart
    {
        public List<GunHolder> GunsWillRent;
        public List<LaneHolder> LanesWillRent;
        public Dictionary<LaneEnum, bool> Lanes;

        public Cart()
        {
            Lanes = new Dictionary<LaneEnum, bool>();

            Lanes.Add(LaneEnum.SHORT,false);
            Lanes.Add(LaneEnum.MIDDLE, false);
            Lanes.Add(LaneEnum.LONG, false);
            Lanes.Add(LaneEnum.XLONG, false);

            GunsWillRent = new List<GunHolder>();
            LanesWillRent = new List<LaneHolder>();
        }

        public bool ContainsLane(LaneEnum searched)
		{
            foreach (LaneHolder lane in LanesWillRent)
			{
                if (lane.LaneType == searched)
				{
                    return true;
				}
			}
            return false;
		}
    }
}
