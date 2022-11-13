namespace KursALX.Lessons.M2.L1
{
    public class L1Arrays
    {
        public static void Run()
        {
            int[] intArray = { 0, 1, 2, 3, 4};
            int[] intArray2 = new int[5];
            int[,] intMatrix = new int[3,2];
            ShowArray(intArray);

            intArray2[2] = 2;
            ShowArray(intArray2);
        }
        public static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
