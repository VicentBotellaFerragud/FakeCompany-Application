using System;
using System.Collections.Generic;

namespace FakeCompany_Application.Data.Models
{
    public partial class Manager
    {
        public Manager()
        {
            Employees = new HashSet<Employee>();
            ManagerSales = new HashSet<ManagerSale>();
        }

        public int ManagerId { get; set; }
        public string ManagerName { get; set; } = null!;
        public int Salary { get; set; }
        public int? DepartmentId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Project? Project { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ManagerSale> ManagerSales { get; set; }
    }
}
