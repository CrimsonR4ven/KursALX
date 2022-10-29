namespace KursALX.Lessons.Classes
{
    public class Dog
    {
        public string name;
        public string race;

        public int age;

        // Bez sensu zmienna, zawsze wynosi True
        public bool goodBoi = true;

        public void Jump()
        {
            Console.WriteLine("Boing! Boing!");
        }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
        public static void Eat()
        {
            Console.WriteLine("Nom...Nom..");
        }
        public int GetOlderAge()
        {
            return age + 1;
        }
        public void GrowOlder(int numberOfYears)
        {
            age = age + numberOfYears;
        }
        public int Add(int x, int y)
        {
            return (x + y);
        }
        public DogOffspringStats Breed(int malePups,int femalePups)
        {
            DogOffspringStats dogOffspringStats = new DogOffspringStats();
            dogOffspringStats.NumberOfMalePups = malePups;
            dogOffspringStats.NumberOfFemalePups = femalePups;

            return dogOffspringStats;
        }
        public void Present()
        {
            Console.WriteLine($"Attention! Great boi approaches you, his name is {name}");
            Console.WriteLine("Race: " + race);
            Console.WriteLine("Age of good boi: " + age);
            Console.WriteLine("is he good boi? " + goodBoi);
        }
    }
}
