namespace ShootingRangeForms.Objects
{
    public class Gun
    {
        public string Name;
        public string Description;
        public string ImgLocation;
        public double Price;
        public int Amount;

        public Gun(string name, string description, string imgLocation, double price)
        {
            Name = name;
            Description = description;
            ImgLocation = imgLocation;
            Price = price;
            Amount = 0;
        }
    }
}
