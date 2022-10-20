using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public int Salary { get; set; }
        public Manager Manager { get; set; }
        public int ManagerId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; } 
    }
}