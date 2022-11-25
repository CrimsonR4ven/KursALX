namespace TotallyRandomThings
{
    public class NumeroUno: Human
    {
        public NumeroUno()
        {
            Name = "Monika";
            SurName = "Monika";
        }
        public NumeroUno(Human human)
        {
            Name = human.Name;
            SurName = human.SurName;
        }
        public override void BMI()
        {
            Console.WriteLine($"{Name} {SurName} BMI Klasy Uno");
        }
    }
}
