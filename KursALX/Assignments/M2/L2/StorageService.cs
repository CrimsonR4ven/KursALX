using KursALX.Assignments.M2.L1;

namespace KursALX.Assignments.M2.L2
{
    public class StorageService
    {
        List<Book> SciFiBooks;
        List<Book> FantasyBooks;
        List<Book> HorrorBooks;
        List<Book> CriminalBooks;
        List<Book> WesternBooks;
        List<Book> DystopianBooks;

        public StorageService()
        {
            SciFiBooks = new List<Book>();
            FantasyBooks = new List<Book>();
            HorrorBooks = new List<Book>();
            CriminalBooks = new List<Book>();
            WesternBooks = new List<Book>();
            DystopianBooks = new List<Book>();
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("SciFi Books:\n");
            Present(SciFiBooks);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Fantasy Books:\n");
            Present(FantasyBooks);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Horror Books:\n");
            Present(HorrorBooks);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Criminal Books:\n");
            Present(CriminalBooks);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Western Books:\n");
            Present(WesternBooks);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Dystopian Books:\n");
            Present(DystopianBooks);
        }

        public void StoreOnShelf(Book book)
        {
            switch (book.BookGenre)
            {
                case Genre.SCIFI:
                    SciFiBooks.Add(book);
                    break;
                case Genre.FANTASY:
                    FantasyBooks.Add(book);
                    break;
                case Genre.HORROR:
                    HorrorBooks.Add(book);
                    break;
                case Genre.CRIMINAL:
                    CriminalBooks.Add(book);
                    break;
                case Genre.WESTERN:
                    WesternBooks.Add(book);
                    break;
                case Genre.DYSTOPIAN:
                    DystopianBooks.Add(book);
                    break;
            }
        }

        public Book CreateBook()
        {
            Console.Clear();
            Console.WriteLine("What Genre Is Your Book? (SciFi - 0, Fantasy - 1, Horror - 2, Criminal - 3, Western - 4, Dystopian - 5)");
            Console.Write("Genre: ");
            int genre = int.Parse(Console.ReadLine());
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author  = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Year of publishment: ");
            int yearOfPublishment = int.Parse(Console.ReadLine());

            var book = new Book((Genre)genre, title, author, description, yearOfPublishment);
            Console.WriteLine("Book Added");
            return book;
        }

        public void Present(List<Book> listBooks)
        {
            foreach (Book book in listBooks)
            {
                Console.WriteLine($"Author: {book.Author} Title: \"{book.Title}\"");
                Console.WriteLine($"Description: {book.Description} Year of publishment: {book.YearOfPublishment}\n");
            }
        }
    }
}
