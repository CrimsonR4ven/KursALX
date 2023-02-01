namespace ShootingRangeForms.Objects
{
    public class Cart
    {
        public Dictionary<string, bool> Lanes;
        public List<GunHolder> GunsWillBuy;
        public Cart()
        {
            Lanes = new Dictionary<string, bool>();
            Lanes.Add("Short",false);
            Lanes.Add("Mid", false);
            Lanes.Add("Long", false);
            GunsWillBuy = new List<GunHolder>();
        }
    }
}
