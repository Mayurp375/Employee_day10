using EmployeeWag_4;

namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employeebuilding empWage = new Employeebuilding();

            empWage.addCompanyEmpWage("jio", 30, 7, 10);
            empWage.addCompanyEmpWage("Reilance", 20, 6, 20);

            empWage.computeEmpWage();
            Console.WriteLine("Total Wage for DMart company: " + empWage.getTotalEmpWage(0));
        }
    }
}
