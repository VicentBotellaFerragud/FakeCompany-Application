using FakeCompany_Application.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCompany_Application.Data
{
    public class FakeCompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeSale> EmployeeSales { get; set; }
        public DbSet<ManagerSale> ManagerSales { get; set; }
    }
}
