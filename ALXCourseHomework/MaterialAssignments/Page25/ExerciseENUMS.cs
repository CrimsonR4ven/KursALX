namespace ALXCourseHomework.MaterialAssignments.Page25
{
    public class ExerciseENUMS
    {
        public static void EveryEnumValue()
        {
            foreach (var month in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(month);
            }
        }

        public static void EnumToList()
        {
            List<string> monthsList = new List<string>();

            foreach (var month in Enum.GetValues(typeof(Months)))
            {
                monthsList.Add(month.ToString());
            }
            foreach (var month in monthsList)
            {
                Console.WriteLine(month);
            }
            
        }
    }
}
