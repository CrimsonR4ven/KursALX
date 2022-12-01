using System.Xml.Serialization;

namespace TotallyRandomThings
{
    public abstract class Human
    {
        public string Name;
        public string SurName;
        public virtual void BMI()
        {
            Console.WriteLine($"{Name} {SurName} BMI Human");
        }
        public static Human ChangeSex(Human human)
        {
            Console.WriteLine("Choose: Uno/Due/Tre");
            Console.Write("Choice:");
            string choice = Console.ReadLine().ToLower();
            switch(choice)
            {
                case "uno":
                    return new NumeroUno(human);
                case "due":
                    return new NumeroDue(human);
                case "tre":
                    return new NumeroTre(human);
                default:
                    Console.WriteLine("Wrong Choice!");
                    return human;
            }
        }
    }
}
