using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Domain
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string ManagerName { get; set; } = string.Empty;
        public int Salary { get; set; }
        public List<Employee> EmployeesAssigned { get; set; } = new List<Employee>();
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
    }
}
