using KursALX.Lessons.L1.Classes;

namespace KursALX.Lessons.L1
{
    public class L1Constructors
    {
        public static void Run()
        {
            var spider = new Spider();
            var crimsonSpider = new Spider("Crimson", "Cool One", "Male", true);
            var blueSpider = new Spider("Blue", "Goliath");
            var greenSpider = new Spider("green", false);
            var copyBlueSpider = new Spider(blueSpider);
            spider.Color = "Black";
            spider.Species = "Not cool";
            spider.Sex = "Female";
            spider.IsVenomous = false;

            spider.Present();
            crimsonSpider.Present();
            blueSpider.Present();
            greenSpider.Present();
            copyBlueSpider.Present();
        }
    }
}
