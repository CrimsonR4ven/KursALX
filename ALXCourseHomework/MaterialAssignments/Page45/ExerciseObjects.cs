namespace ALXCourseHomework.MaterialAssignments.Page45
{
    public class ExerciseObjects
    {
        public static void CarExercise()
        {
            string priceCar1,priceCar2,priceCar3;
            Car car1 = new Car("BMW", 50000, 20000, 0.23);
            Car car2 = new Car("Audi", 40000, 20000, 0.09);
            Car car3 = new Car("Mercedes", 60000, 40000, 0.19);
            priceCar1 = car1.CarBruttoPrice().ToString();
            priceCar2 = car2.CarBruttoPrice().ToString();
            priceCar3 = car3.CarBruttoPrice().ToString();

            car1.Present();
            Console.WriteLine($"Car brutto price: " + priceCar1);
            car2.Present();
            Console.WriteLine($"Car brutto price: " + priceCar2);
            car3.Present();
            Console.WriteLine($"Car brutto price: " + priceCar3);
        }
        public static void Welcome()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            char lastLetter = name[name.Length - 1];
            if (lastLetter == 'a')
            {
                Console.WriteLine("Hello Mrs. " + name);
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hello Mr. " + name);
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }
        }
    }
}
