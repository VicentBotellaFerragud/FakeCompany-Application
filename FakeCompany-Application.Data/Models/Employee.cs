using System;
using System.Collections.Generic;

namespace FakeCompany_Application.Data.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeSales = new HashSet<EmployeeSale>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public int Salary { get; set; }
        public int? ManagerId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Manager? Manager { get; set; }
        public virtual Project? Project { get; set; }
        public virtual ICollection<EmployeeSale> EmployeeSales { get; set; }
    }
}
