namespace KursALX.Assignments.M1.Classes
{
    public class Car
    {
        public string Color;
        public string Make;
        public string Model;
        public int Doors;
        public bool IsFast;

        public Car(Car copy)
        {
            Color = copy.Color;
            Make = copy.Make;
            Model = copy.Model;
            Doors = copy.Doors;
            IsFast = copy.IsFast;
        }

        public Car(string color)
        {
            Color = color;
            Make = "Ford";
            Model = "Focus";
            Doors = 4;
            IsFast = false;
        }

        public Car(string color, string make, string model, int doors, bool isFast)
        {
            Color=color;
            Make = make;
            Model = model;
            Doors = doors;
            IsFast = isFast;
        }


        public void Present()
        {
            Console.WriteLine($"\nNew car is here!");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Is it fast?: {IsFast}");
            Console.WriteLine($"It has {Doors} Doors!\n");
        }

        public void Drive()
        {
            Console.WriteLine("Nope i can't, no fuel mate");
        }
    }
}
