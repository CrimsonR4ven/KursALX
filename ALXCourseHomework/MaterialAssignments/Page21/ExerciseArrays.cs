using System.Security.Authentication.ExtendedProtection;

namespace ALXCourseHomework.MaterialAssignments.Page21
{
    public class ExerciseArrays
    {
        public static void ArrayShop()
        {
            double[,] ArrayProducts = new double[5, 5] { {1,3.58,5,10,2}, {2,9.61,5,25,5}, {3,8.52,8,18,3}, {4,10.25,8,36,6}, {5,6.17,23,4,1} };
            for (int i = 0; i < 5; i++)
            {
                double valueBrutto    = Math.Round(ArrayProducts[i, 1] + ArrayProducts[i, 1] * (ArrayProducts[i, 2]/100),2);
                double valueWarehouse = Math.Round(valueBrutto * ArrayProducts[i, 3] * ArrayProducts[i, 4], 2);

                Console.WriteLine($"\nValue Brutto item {i+1}: {valueBrutto} Storage Value: {valueWarehouse}\n");
                Console.WriteLine($"-----Product tag {i+1}-----");
                Console.WriteLine($"   ID of an item: {i}");
                Console.WriteLine($"   Price netto:   {ArrayProducts[i, 1]}");
                Console.WriteLine($"   Vat:           {ArrayProducts[i, 2]}%");
                Console.WriteLine($"   Price brutto:  {valueBrutto}");
                Console.WriteLine($"   Storage value: {valueWarehouse}");
            }
        }
        public static void Divisors()
        {
            List<int> divisors = new List<int>();
            Console.Write("Write a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                }
            }
            foreach(int i in divisors)
            {
                Console.WriteLine(i);
            }
        }
    }
}
