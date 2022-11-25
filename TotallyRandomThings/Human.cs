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
    }
}
