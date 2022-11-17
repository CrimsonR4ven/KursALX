using ALXCourseHomework.MaterialAssignments.Page12.Enums;

namespace ALXCourseHomework.MaterialAssignments.Page12
{
    public class ExerciseVariables
    {
        public static void PersonalData()
        {
            string name = "Antón";
            string surname = "Castillo";
            int age = 65;
            double height = 1.92;
            double weight = 92;
            string sex = "Male";
            double intHeight = height * 100;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age} years");
            Console.WriteLine($"Height: {height} m");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Sex: {sex}\n");

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age} years");
            Console.WriteLine($"Height: {intHeight} m");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Sex: {sex}\n");
        }

        public static void Day()
        {
            Console.WriteLine("today is: " + (WeekDay)5 + " " + (Month)10 + " 2022");
        }
    }
}
