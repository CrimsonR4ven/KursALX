namespace TotallyRandomThings
{
    public class NumeroDue:Human
    {
        public NumeroDue()
        {
            Name = "Andrzej";
            SurName = "Andrzej";
        }
        public NumeroDue(Human human)
        {
            Name = human.Name;
            SurName = human.SurName;
        }
        public override void BMI()
        {
            Console.WriteLine($"{Name} {SurName} BMI Klasy Due");
        }
    }
}
