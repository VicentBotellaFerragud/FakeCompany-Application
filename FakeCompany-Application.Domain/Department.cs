using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Domain
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public List<Employee> EmployeesAssigned { get; set; } = new List<Employee>();
        public List<Manager> ManagersAssigned { get; set; } = new List<Manager>();
    }
}
