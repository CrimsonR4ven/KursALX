namespace ALXCourseHomework.MaterialAssignments.Page23
{
    public class ExerciseArrays2
    {
        public static void DatabaseItems()
        {
            string[] products = new string[] { "Mayo", "Gurken", "Sugar", "Bajeczny" };
            double[] prices   = new double[] { 5, 3.4, 3, 1.1 };
            int i = 1;

            Console.WriteLine("List of items:");
            foreach (string item in products)
            {
                Console.WriteLine($"{i}: {item}");
                i++;
            }
            Console.WriteLine("Choose which item's price you want to see: ");
            var choice = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your item: {products[choice - 1]}");
            Console.WriteLine($"Brutto price: {prices[choice - 1]} zł");
            Console.WriteLine($"Netto price: {Math.Round(prices[choice - 1] / 1.23,2)} zł");
        }

        public static void CoolMatrix()
        {
            int[,] matrix = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                    Console.Write(matrix[i, j]);
                }
                Console.Write("\n");
            }
        }

        public static void ArrayButMakeItLarger()
        {
            const int constant = 5;
            int[] numbero = new int[5];
            Console.WriteLine("Podaj 5 liczb");
            for (int i = 0; i < 5; i++)
            {
                numbero[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("[");
            for (int i = 0; i < 5; i++)
            {
                numbero[i] = numbero[i] + constant;
                Console.Write($"{numbero[i]} ");
            }
            Console.Write("]");
        }
    }
}
