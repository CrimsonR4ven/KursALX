namespace KursALX.Assignments.M2.L1
{
    public class SeniorityService
    {
        public List<Employee> JuniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> SeniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>();
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }
        public void ClassifySeniorityBySalary(Employee employee)
        {
            switch (employee.Salary)
            {
                case < 7059:
                    JuniorEmployees.Add(employee);
                    break;
                case < 20080:
                    MidEmployees.Add(employee);
                    break;
                case >= 20080:
                    SeniorEmployees.Add(employee);
                    break;
            }
        }
        public void ClassifySeniorityByExperience(Employee employee)
        {

            switch (employee.Experience)
            {
                case < 12:
                    JuniorEmployees.Add(employee);
                    break;
                case < 24:
                    MidEmployees.Add(employee);
                    break;
                case >= 24:
                    SeniorEmployees.Add(employee);
                    break;
            }
        }
    }
}
