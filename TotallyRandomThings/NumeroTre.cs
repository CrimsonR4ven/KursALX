namespace TotallyRandomThings
{
    public class NumeroTre: Human
    {
        public NumeroTre()
        {
            Name = "Monika";
            SurName = "Monika";
        }
        public NumeroTre(Human human)
        {
            Name = human.Name;
            SurName = human.SurName;
        }
        public override void BMI()
        {
            Console.WriteLine($"{Name} {SurName} BMI Klasy Tre");
        }
    }
}
