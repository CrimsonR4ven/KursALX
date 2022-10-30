namespace ALXKalkulator.CalculatorOb
{
    public class Calculator
    {
        double liczba1;
        double liczba2;
        public void Calculate()
        {
            Console.Write("Podaj liczbę nr 1: ");
            liczba1 = double.Parse(Console.ReadLine());
            Console.Write("\nPodaj liczbę nr 2: ");
            liczba2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n--------Menu--------");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.Write("Wybierz działanie: ");
            var wybor = double.Parse(Console.ReadLine());
            if(wybor == 1)
            {
                Console.WriteLine($"Wynik twojego działania {liczba1} + {liczba2} = {liczba1 + liczba2}");
            }
            else if (wybor == 2)
            {
                Console.WriteLine($"Wynik twojego działania {liczba1} - {liczba2} = {liczba1 - liczba2}");
            }
            else if (wybor == 3)
            {
                Console.WriteLine($"Wynik twojego działania {liczba1} * {liczba2} = {liczba1 * liczba2}");
            }
            else if (wybor == 4)
            {
                if (liczba2 == 0)
                {
                    Console.WriteLine($"Nie można dzielić przez 0");
                }
                else
                {
                    Console.WriteLine($"Wynik twojego działania {liczba1} / {liczba2} = {liczba1 / liczba2}");
                }
            }
            else
            {
                Console.WriteLine("Nie ma takiego działania");
            }
        }
    }
}
