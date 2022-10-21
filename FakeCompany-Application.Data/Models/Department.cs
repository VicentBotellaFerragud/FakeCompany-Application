using System;
using System.Collections.Generic;

namespace FakeCompany_Application.Data.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            Managers = new HashSet<Manager>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}
