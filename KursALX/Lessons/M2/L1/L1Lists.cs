namespace KursALX.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shoppnigList = new List<string>();

            shoppnigList.Add("Tea");
            ShowList(shoppnigList);

            shoppnigList.Add("More tea");
            ShowList(shoppnigList);

            shoppnigList.Add("MORE TEA");
            ShowList(shoppnigList);

            shoppnigList.Add("EVEN MORE TEA");
            ShowList(shoppnigList);

            shoppnigList.Add("WAY TOO MUCH TEA");
            ShowList(shoppnigList);

            shoppnigList.Add("WHY DO YOU EVEN NEED THAT TEA");
            ShowList(shoppnigList);

            shoppnigList.Remove("WHY DO YOU EVEN NEED THAT TEA");
            ShowList(shoppnigList);

            shoppnigList.Remove("WAY TOO MUCH TEA");
            ShowList(shoppnigList);

            shoppnigList.Remove("EVEN MORE TEA");
            ShowList(shoppnigList);

            shoppnigList.Remove("MORE TEA");
            ShowList(shoppnigList);

            shoppnigList.Remove("More tea");
            ShowList(shoppnigList);
        }
        public static void ShowList(List<string> list)
        {
            Console.WriteLine(list.Count);
            foreach (string thing in list)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine();
        }
    }
}
