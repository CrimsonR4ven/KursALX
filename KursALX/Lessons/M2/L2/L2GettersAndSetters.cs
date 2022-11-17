using KursALX.Lessons.M2.L2.Classes;

namespace KursALX.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();
            computer.Brand = "Dell";
            computer.ProcessorFrequency = 3.14;
            computer.NumberOfCores = 5;
            PresentComputer(computer);
        }
        private static void PresentComputer(Computer computer)
        {
            Console.WriteLine($"Brand: {computer.Brand} \nFrequency: {computer.ProcessorFrequency} \nNumber of cores: {computer.NumberOfCores} \n");
        }
    }
}
