using ADODemo;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ADODemos de = new ADODemos();
de.Run("Data Source=RUBY\\SQLEXPRESS;Initial Catalog=RentMovieOnDrugs;Integrated Security=true;Connect Timeout=30", "[MovieName]","v");