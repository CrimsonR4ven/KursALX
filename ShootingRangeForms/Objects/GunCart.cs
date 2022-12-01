﻿namespace ShootingRangeForms.Objects
{
    public class GunCart
    {
        public Dictionary<string, bool> Lanes;
        public List<Gun> GunsWillBuy;
        public GunCart()
        {
            Lanes = new Dictionary<string, bool>();
            Lanes.Add("Short",false);
            Lanes.Add("Mid", false);
            Lanes.Add("Long", false);
            GunsWillBuy = new List<Gun>();
        }
    }
}
