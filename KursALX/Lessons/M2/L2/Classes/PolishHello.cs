using KursALX.Lessons.M2.L2.Interfaces;

namespace KursALX.Lessons.M2.L2.Classes
{
    public class PolishHello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Dzień Dobry");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Dzień Dobry {name}");
        }

        public void SayHello()
        {
            Console.WriteLine("Cześć");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"cześć {name}");
        }
    }
}
