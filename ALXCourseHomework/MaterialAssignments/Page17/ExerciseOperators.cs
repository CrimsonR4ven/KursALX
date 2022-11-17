namespace ALXCourseHomework.MaterialAssignments.Page17
{
    public class ExerciseOperators
    {
        public static void MathCool(double a, double b, double c)
        {
            double value = (Math.Pow(a, b) / 2) % c;
            bool isTrue = value + 5 > a;

            Console.WriteLine($"Math operation: (({a}^{b})/2)%{c} \nresult: {value}");
            Console.WriteLine($"Statement: ,,Operation value + 5 is greater than a = {a}'' is {isTrue}");
        }
        
        public static void DeMorganLaw()
        {
            bool pFalse = false;
            bool pTrue = true;
            bool qFalse = false;
            bool qTrue = true;
            bool check1 = !(pTrue | qTrue) == (!pTrue & !qTrue);
            bool check2 = !(pTrue & qTrue) == (!pTrue | !qTrue);
            bool check3 = !(pTrue | qFalse) == (!pTrue & !qFalse);
            bool check4 = !(pTrue & qFalse) == (!pTrue | !qFalse);
            bool check5 = !(pFalse | qTrue) == (!pFalse & !qTrue);
            bool check6 = !(pFalse & qTrue) == (!pFalse | !qTrue);
            bool check7 = !(pFalse | qFalse) == (!pFalse & !qFalse);
            bool check8 = !(pFalse & qFalse) == (!pFalse | !qFalse);

            Console.WriteLine("First De Morgan Law for p = false q = false is: " + check7);
            Console.WriteLine("First De Morgan Law for p = false q = true is: " + check5);
            Console.WriteLine("First De Morgan Law for p = true q = false is: " + check3);
            Console.WriteLine("First De Morgan Law for p = true q = true is: " + check1);
            Console.WriteLine("Second De Morgan Law for p = false q = false is: " + check8);
            Console.WriteLine("Second De Morgan Law for p = false q = true is: " + check6);
            Console.WriteLine("Second De Morgan Law for p = true q = false is: " + check4);
            Console.WriteLine("Second De Morgan Law for p = true q = true is: " + check2);
        }
    }
}
