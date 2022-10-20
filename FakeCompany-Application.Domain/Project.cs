using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Domain
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public List<Employee> EmployeesAssigned { get; set; } = new List<Employee>();
        public List<Manager> ManagersAssigned { get; set; } = new List<Manager>();
    }
}
