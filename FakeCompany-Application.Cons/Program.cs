using FakeCompany_Application.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Cons
{
    public class Program
    {
        private static FakeCompanyContext context = new FakeCompanyContext();

        private static void Main(string[] args)
        {
            GetEmployees();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void GetEmployees()
        {
            List<Employee> employees = context.Employees.ToList();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Employees from the Fake Company:");
            Console.WriteLine("");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.EmployeeName);
                Console.WriteLine("");
            }
        }
    }
}
