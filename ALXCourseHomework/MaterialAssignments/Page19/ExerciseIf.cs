namespace ALXCourseHomework.MaterialAssignments.Page19
{
    public class ExerciseIf
    {
        public static void Discount1()
        {
            double FinalPrice;
            Console.Write("Original price:  ");
            double Price = double.Parse(Console.ReadLine());

            if (Price >= 100)
            {
                FinalPrice = Price - (Price * 0.15);
                Console.WriteLine("You received discount: 15%");
                Console.WriteLine($"Final price:  {FinalPrice}");
            }
            else if ((Price < 100) & (Price >= 60))
            {
                FinalPrice = Price - (Price * 0.05);
                Console.WriteLine("You received discount: 5%");
                Console.WriteLine($"Final price:  {FinalPrice}");
            }
            else if ((Price < 60) & (Price >= 0))
            {
                FinalPrice = Price;
                Console.WriteLine("There is no discount for you");
                Console.WriteLine($"Final price:  {FinalPrice}");
            }
            else
            {
                Console.WriteLine("Wait, You want us to give you money?!");
            }
        }

        public static void Discount2()
        {
            double FinalPrice;
            Console.Write("Original price:");
            double Price = double.Parse(Console.ReadLine());

            switch (Price)
            {
                case < 0:
                    Console.WriteLine("Wait, You want us to give you money?!");
                    break;
                case < 60:
                    FinalPrice = Price;
                    Console.WriteLine("There is no discount for you");
                    Console.WriteLine($"Final price: {FinalPrice}");
                    break;
                case < 100:
                    FinalPrice = Price - (Price * 0.05);
                    Console.WriteLine("You received discount: 5%");
                    Console.WriteLine($"Final price: {FinalPrice}");
                    break;
                case >= 100:
                    FinalPrice = Price - (Price * 0.15);
                    Console.WriteLine("You received discount: 15%");
                    Console.WriteLine($"Final price: {FinalPrice}");
                    break;
            }
        }
    }
}
