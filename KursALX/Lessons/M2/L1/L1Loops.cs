namespace KursALX.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> list = new List<string>();
            list.Add("Pepperoni");
            list.Add("Margharitta");
            list.Add("Neopolitan");
            list.Add("CoolOne");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        public static void RunFor()
        {
            int[] array = {1, 3, 3, 4, 5, 6, 7, 8, 9, 1 ,11, 12, 130, 134};
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void RunWhile()
        {
            char c = 'c';
            while(c == 'c')
            {
                Console.WriteLine(c);
                c = Console.ReadKey().KeyChar;
            }
        }
        public static void RunDoWhile()
        {
            char c = 'c';
            do
            {
                Console.WriteLine(c);
                c = Console.ReadKey().KeyChar;
            } while (c == 'c');

        }
    }
}
