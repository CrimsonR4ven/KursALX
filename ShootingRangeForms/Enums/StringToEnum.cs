using ShootingRangeData.ShootingRangeDB;

namespace ShootingRangeForms.Enums
{
	public static class StringToEnum
	{
        public static CategoryEnum GetCategory(GunCategory category)
        {
            switch (category.Name)
            {
                case ("HandGuns"):
                    return CategoryEnum.HANDGUNS;
                case ("Revolvers"):
                    return CategoryEnum.REVOLVERS;
                case ("Rifles"):
                    return CategoryEnum.RIFLES;
                case ("Shotguns"):
                    return CategoryEnum.SHOTGUNS;
                case ("Machine Guns"):
                    return CategoryEnum.MACHINEGUNS;
                case ("Sniper Rifles"):
                    return CategoryEnum.SNIPERRIFLES;
                default:
                    return CategoryEnum.UNDEFINED;
            }
        }
        public static LaneEnum GetLane(GunLaneType lane)
        {
            switch (lane.Name)
            {
                case ("Short"):
                    return LaneEnum.SHORT;
                case ("Middle"):
                    return LaneEnum.MIDDLE;
                case ("Long"):
                    return LaneEnum.LONG;
                case ("Extra Long"):
                    return LaneEnum.XLONG;
                default:
                    return LaneEnum.UNDEFINED;
            }
        }
    }
}
