namespace KursALX.Lessons.L1.Classes
{
    public class Spider
    {
        public string Color;
        public string Species;
        public string Sex;
        public bool IsVenomous;

        public Spider() { }

        public Spider(Spider copy)
        {
            Color      = copy.Color;
            Species    = copy.Species;
            Sex        = copy.Sex;
            IsVenomous = copy.IsVenomous;
        }

        public Spider(string color, string species)
        {
            Color      = color;
            Species    = species;
            Sex        = "Male";
            IsVenomous = true;
        }

        public Spider(string color, string species, string sex, bool isVenomous)
        {
            Color      = color;
            Species    = species;
            Sex        = sex;
            IsVenomous = isVenomous;
        }
        public Spider(string color, bool isVenomous)
        {
            Color      = color;
            IsVenomous = isVenomous;
        }

        public void Present()
        {
            Console.WriteLine($"\nhere is a new spider");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"Is venomous?: {IsVenomous}");
        }
    }
}
