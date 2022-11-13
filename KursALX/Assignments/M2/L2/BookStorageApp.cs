namespace KursALX.Assignments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            StorageService storageService = new StorageService();
            while (true)
            {
                var book = storageService.CreateBook();
                storageService.StoreOnShelf(book);
                storageService.Run();
                Console.Write("Do you want to continue (Yes/No):");
                string doYouWant = Console.ReadLine().ToLower();
                if (doYouWant == "no")
                {
                    break;
                }
            }
        }
    }
}
