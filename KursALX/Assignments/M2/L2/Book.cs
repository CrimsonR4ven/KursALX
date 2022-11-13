namespace KursALX.Assignments.M2.L2
{
    public class Book
    {
        public Genre BookGenre;
        public string Title;
        public string Author;
        public string Description;
        public int YearOfPublishment;

        public Book(Genre bookGenre, string title, string author, string description, int yearOfPublishment)
        {
            BookGenre = bookGenre;
            Title = title;
            Author = author;
            Description = description;
            YearOfPublishment = yearOfPublishment;
        }
    }
}
