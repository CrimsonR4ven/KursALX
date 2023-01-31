using ShootingRangeData.ShootingRangeDB;

namespace ShootingRangeForms.Enums
{
	public static class OperationsOnEnum
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
        public static string GetCategory(CategoryEnum category)
        {
            switch (category)
            {
                case (CategoryEnum.HANDGUNS):
                    return "HandGuns";
                case (CategoryEnum.REVOLVERS):
                    return "Revolvers";
                case (CategoryEnum.RIFLES):
                    return "Rifles";
                case (CategoryEnum.SHOTGUNS):
                    return "Shotguns";
                case (CategoryEnum.MACHINEGUNS):
                    return "Machine Guns";
                case (CategoryEnum.SNIPERRIFLES):
                    return "Sniper Rifles";
                default:
                    throw new Exception("Undefined category");
            }
        }
        public static LaneEnum GetLaneEnum(GunLaneType lane)
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
