using System;
using System.Collections.Generic;

namespace FakeCompany_Application.Data.Models
{
    public partial class Project
    {
        public Project()
        {
            Employees = new HashSet<Employee>();
            Managers = new HashSet<Manager>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}
