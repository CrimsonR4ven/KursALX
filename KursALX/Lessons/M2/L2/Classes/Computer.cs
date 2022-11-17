namespace KursALX.Lessons.M2.L2.Classes
{
    public class Computer
    {
        private string _brand;
        private double _processorFrequency;
        public string Brand
        {
            get 
            {
                Console.WriteLine("Getting PC brand");
                return _brand; 
            }
            set 
            {
                Console.WriteLine($"Setting computer brand as {value}");
                _brand = value; 
            }
        }
        public int NumberOfCores;
        public double ProcessorFrequency 
        { 
            get 
            {
                Console.WriteLine("Getting processor Frequency");
                return _processorFrequency; 
            } 
            set 
            {
                if (value > 0 && value < 4)
                {
                    Console.WriteLine($"Setting Processor frequency as {value}");
                    _processorFrequency = value;
                }
                else
                {
                    Console.WriteLine("invalid value fo frequency");
                }
            } 
        }
        public readonly string GraphicalCardModel; 
    }
}
