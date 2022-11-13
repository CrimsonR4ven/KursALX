namespace KursALX.Assignments.M2.L1
{
    public class SeniorityServiceTest
    {
        public static void Test()
        {
            var seniorityService = new SeniorityService();
            var jose = new Employee("Jose", 300230, 4);
            var juan = new Employee("Juan", 21000, 18);
            var john = new Employee("John", 1024, 5);
            var jacob = new Employee("Jacob", 15808, 16);
            var joseph = new Employee("Joseph", 36052, 2);
            var anton = new Employee("Anton", 2048, 28);

            seniorityService.ClassifySeniorityBySalary(anton);
            seniorityService.ClassifySeniorityBySalary(joseph);
            seniorityService.ClassifySeniorityBySalary(jose);
            seniorityService.ClassifySeniorityByExperience(jacob);
            seniorityService.ClassifySeniorityByExperience(john);
            seniorityService.ClassifySeniorityByExperience(juan);

            Console.WriteLine("Juniors");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors");
            PresentEmployees(seniorityService.SeniorEmployees);
        }
        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary} Experience: {employee.Experience}");
            }
        }
    }
}
