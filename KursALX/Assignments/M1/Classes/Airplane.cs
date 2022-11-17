namespace KursALX.Assignments.M1.Classes
{
    public class Airplane
    {
        public string Color;
        public string Name;
        public string Make;
        public string Model;
        public int ProductionYear;
        public bool IsCool;

        public void Welcome()
        {
            Console.WriteLine($"\nWelcome on board!");
            Console.WriteLine($"Today you are flying: \"{Name}\" {Make} {Model} from year {ProductionYear}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Do people think it's cool?: {Color}\n");
        }

        public int WhatIfOlder(int years)
        {
            return ProductionYear + years;
        }
    }
}
