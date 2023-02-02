﻿using ShootingRangeForms.Enums;
using ShootingRangeData.ShootingRangeDB;

namespace ShootingRangeForms.Objects
{
	public class LaneHolder
	{
		public int    Distance;
		public string ImgName;
		public string Name;
		public double RentPrice;
		public string Description;
		public int RentHours;

		public LaneEnum LaneType;

		public LaneHolder(GunLane lane)
		{
			Name        = lane.Name;
			ImgName		= lane.ImgName;
			Distance    = lane.Distance;
			RentPrice   = lane.RentPrice;
			Description = lane.Description;
			LaneType    = OperationsOnEnum.GetLaneEnum(lane.Lane);
		}
		public static List<LaneHolder> FromLaneList(List<GunLane> laneList)
		{
			List<LaneHolder> list = new List<LaneHolder>();
			foreach (GunLane lane in laneList)
			{
				list.Add(new LaneHolder(lane));
			}
			return list;
		}
	}
}
